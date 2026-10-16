using Microsoft.EntityFrameworkCore;

namespace Tooted
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                LooAndmebaasJaKasutajad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Andmebaasi viga: " + ex.Message +
                    "\n\nKas tegid Add-Migration LisaKasutajad ja Update-Database?");
                return;
            }

            // Kõigepealt login, siis peamenüü
            using (var login = new LoginForm())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new Peavorm());
        }

        // Loob andmebaasi (rakendab migratsioonid) ja lisab vaikimisi kasutajad
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
