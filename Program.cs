using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Tooted
{
    internal static class Program
    {


        [STAThread]
        static void Main()
        {
            string lang = Settings.Default.UserLanguage;

            if (string.IsNullOrWhiteSpace(lang))
                lang = "et-EE";

            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo(lang);

            Thread.CurrentThread.CurrentCulture =
                new CultureInfo(lang);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                LooAndmebaasJaKasutajad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Andmebaasi viga: " + ex.Message +
                    "\n\nKas tegid Add-Migration LisaKasutajad " +
                    "ja Update-Database?"
                );

                return;
            }

            using (var login = new LoginForm())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new Peavorm());
        }

        private static void LooAndmebaasJaKasutajad()
        {
            using var db = new ToodedContext();

            db.Database.Migrate();

            if (!db.Kasutajad.Any())
            {
                db.Kasutajad.Add(new Kasutaja
                {
                    Nimi = "Admin",
                    Email = "admin@admin.ee",
                    ParoolHash = PasswordHelper.Hash("admin123"),
                    Roll = "admin"
                });

                db.Kasutajad.Add(new Kasutaja
                {
                    Nimi = "Kasutaja",
                    Email = "kasutaja@kasutaja.ee",
                    ParoolHash = PasswordHelper.Hash("kasutaja123"),
                    Roll = "kasutaja"
                });

                db.SaveChanges();
            }
        }
    }
}