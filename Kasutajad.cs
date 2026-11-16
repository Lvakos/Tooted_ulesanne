using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace Tooted
{
    public class Kasutajad : Form
    {
        private readonly ComponentResourceManager resources =
            new ComponentResourceManager(typeof(Kasutajad));

        private readonly DataGridView grid = new DataGridView();
        private readonly TextBox nameBox = new TextBox();
        private readonly TextBox emailBox = new TextBox();
        private readonly TextBox passwordBox = new TextBox();
        private readonly ComboBox roleBox = new ComboBox();

        private int? selectedId;
        private bool loading;

        private string T(string key, params object[] args)
        {
            string value = resources.GetString(key) ?? key;

            return args.Length == 0
                ? value
                : string.Format(
                    CultureInfo.CurrentCulture,
                    value,
                    args);
        }

        public Kasutajad()
        {
            SuspendLayout();

            Text = T("Title");
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(857, 560);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            BackColor = Color.FromArgb(255, 192, 128);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            AddField("Nimi", nameBox, 26, 0);
            AddField("Email", emailBox, 73, 1);
            AddField("Password", passwordBox, 120, 2);
            AddField("Roll", roleBox, 170, 3);

            passwordBox.UseSystemPasswordChar = true;

            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.Items.AddRange(
                new object[] { T("User"), T("Admin") });

            Controls.Add(new Label
            {
                Text = T("PasswordHint"),
                Location = new Point(437, 32),
                Size = new Size(315, 145),
                Font = new Font("Segoe UI", 11F),
                TabStop = false
            });

            AddButton("Clear", 337, 105, 4, NewUser);

            AddButton(
                "Add", 448, 105, 5,
                () => SaveUser(true));

            AddButton(
                "Update", 559, 95, 6,
                () => SaveUser(false));

            AddButton("Delete", 660, 92, 7, DeleteUser);

            grid.Name = "dataGridKasutajad";
            grid.Location = new Point(115, 279);
            grid.Size = new Size(637, 205);
            grid.TabIndex = 8;

            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.MultiSelect = false;

            grid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grid.AutoGenerateColumns = false;

            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grid.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (string field in
                new[] { "Id", "Nimi", "Email", "Roll" })
            {
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = field,
                    DataPropertyName = field,
                    HeaderText = T(field)
                });
            }

            grid.Columns["Id"].FillWeight = 30;
            grid.Columns["Email"].FillWeight = 160;

            grid.SelectionChanged += (sender, e) => SelectUser();

            grid.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == grid.Columns["Roll"].Index &&
                    e.Value is string role)
                {
                    e.Value = role == "admin"
                        ? T("Admin")
                        : T("User");

                    e.FormattingApplied = true;
                }
            };

            Controls.Add(grid);

            Controls.Add(new PictureBox
            {
                Image = Properties.Resources.waurma,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(726, 495),
                Size = new Size(119, 53),
                TabStop = false
            });

            NewUser();

            ResumeLayout(false);
            PerformLayout();
        }

        private void AddField(
            string key,
            Control input,
            int y,
            int tabIndex)
        {
            Controls.Add(new Label
            {
                Text = T(key),
                Location = new Point(20, y + 5),
                Size = new Size(143, 25),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font(
                    "Segoe UI", 12F, FontStyle.Bold)
            });

            input.Location = new Point(169, y);
            input.Size = new Size(230, 33);
            input.Font = new Font("Segoe UI", 14F);
            input.TabIndex = tabIndex;

            Controls.Add(input);
        }

        private void AddButton(
            string key,
            int x,
            int width,
            int tabIndex,
            Action action)
        {
            var button = new Button
            {
                Text = T(key),
                Location = new Point(x, 218),
                Size = new Size(width, 35),
                BackColor = Color.FromArgb(255, 128, 0),
                ForeColor = Color.White,
                Font = new Font(
                    "Segoe UI", 12F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                TabIndex = tabIndex
            };

            button.Click += (sender, e) => action();

            Controls.Add(button);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            WithAdmin(LoadUsers);
        }

        private void WithAdmin(Action<ToodedContext> action)
        {
            try
            {
                using var db = new ToodedContext();

                bool isAdmin =
                    AktiivneKasutaja.OnAdmin &&
                    db.Kasutajad.Any(k =>
                        k.Id == AktiivneKasutaja.Id &&
                        k.Roll == "admin");

                if (!isAdmin)
                {
                    MessageBox.Show(T("AdminOnly"), Text);
                    Close();
                    return;
                }

                action(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    T("Error", ex.Message),
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadUsers(ToodedContext db)
        {
            var users = db.Kasutajad
                .OrderBy(k => k.Nimi)
                .Select(k => new
                {
                    k.Id,
                    k.Nimi,
                    k.Email,
                    k.Roll
                })
                .ToList();

            loading = true;

            try
            {
                grid.DataSource = users;
            }
            finally
            {
                loading = false;
            }

            NewUser();
        }

        private void NewUser()
        {
            grid.ClearSelection();

            selectedId = null;
            nameBox.Clear();
            emailBox.Clear();
            passwordBox.Clear();
            roleBox.SelectedIndex = 0;

            nameBox.Focus();
        }

        private void SelectUser()
        {
            if (loading || grid.SelectedRows.Count == 0)
                return;

            var row = grid.SelectedRows[0];

            selectedId = (int)row.Cells["Id"].Value;
            nameBox.Text = (string)row.Cells["Nimi"].Value;
            emailBox.Text = (string)row.Cells["Email"].Value;

            roleBox.SelectedIndex =
                (string)row.Cells["Roll"].Value == "admin"
                    ? 1
                    : 0;

            passwordBox.Clear();
        }

        private void SaveUser(bool adding)
        {
            int? targetId = adding ? null : selectedId;

            if (!adding && !targetId.HasValue)
            {
                MessageBox.Show(T("SelectUser"), Text);
                return;
            }

            string name = nameBox.Text.Trim();
            string email =
                emailBox.Text.Trim().ToLowerInvariant();

            string password = passwordBox.Text;

            string role = roleBox.SelectedIndex == 1
                ? "admin"
                : "kasutaja";

            bool validEmail;

            try
            {
                validEmail =
                    new MailAddress(email).Address == email;
            }
            catch (FormatException)
            {
                validEmail = false;
            }
            catch (ArgumentException)
            {
                validEmail = false;
            }

            if (name.Length == 0 || !validEmail)
            {
                MessageBox.Show(T("InvalidDetails"), Text);
                return;
            }

            if ((!targetId.HasValue || password.Length > 0) &&
                password.Length < 6)
            {
                MessageBox.Show(T("ShortPassword"), Text);
                return;
            }

            WithAdmin(db =>
            {
                bool emailExists = db.Kasutajad.Any(k =>
                    k.Id != (targetId ?? 0) &&
                    k.Email.ToLower() == email);

                if (emailExists)
                {
                    MessageBox.Show(T("DuplicateEmail"), Text);
                    return;
                }

                var user = targetId.HasValue
                    ? db.Kasutajad.Find(targetId.Value)
                    : new Kasutaja();

                if (user == null)
                {
                    MessageBox.Show(T("NotFound"), Text);
                    LoadUsers(db);
                    return;
                }

                if (user.Id == AktiivneKasutaja.Id &&
                    role != "admin")
                {
                    MessageBox.Show(T("OwnRole"), Text);
                    return;
                }

                if (user.Roll == "admin" &&
                    role != "admin" &&
                    db.Kasutajad.Count(k => k.Roll == "admin") <= 1)
                {
                    MessageBox.Show(T("LastAdmin"), Text);
                    return;
                }

                user.Nimi = name;
                user.Email = email;
                user.Roll = role;

                if (password.Length > 0)
                {
                    user.ParoolHash =
                        PasswordHelper.Hash(password);
                }

                if (!targetId.HasValue)
                {
                    db.Kasutajad.Add(user);
                }

                db.SaveChanges();

                if (user.Id == AktiivneKasutaja.Id)
                {
                    AktiivneKasutaja.Nimi = user.Nimi;
                }

                LoadUsers(db);
            });
        }

        private void DeleteUser()
        {
            if (!selectedId.HasValue)
            {
                MessageBox.Show(T("SelectUser"), Text);
                return;
            }

            WithAdmin(db =>
            {
                var user = db.Kasutajad.Find(selectedId.Value);

                if (user == null)
                {
                    MessageBox.Show(T("NotFound"), Text);
                    LoadUsers(db);
                    return;
                }

                if (user.Id == AktiivneKasutaja.Id)
                {
                    MessageBox.Show(T("OwnDelete"), Text);
                    return;
                }

                if (user.Roll == "admin" &&
                    db.Kasutajad.Count(k => k.Roll == "admin") <= 1)
                {
                    MessageBox.Show(T("LastAdmin"), Text);
                    return;
                }

                var answer = MessageBox.Show(
                    T("ConfirmDelete", user.Nimi),
                    Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (answer != DialogResult.Yes)
                    return;


                db.Kasutajad.Remove(user);
                db.SaveChanges();

                LoadUsers(db);
            });
        }
    }
}