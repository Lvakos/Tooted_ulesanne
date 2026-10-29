using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace Tooted
{
    public static class ArvePdf
    {
        public const string MyyjaNimi = "Waurma pood";
        private const decimal KaibemaksProtsent = 24m;

        private static readonly XColor Oranz = XColor.FromArgb(255, 128, 0);
        private static readonly XColor Hall = XColor.FromArgb(110, 110, 110);
        private static readonly XColor HeleOranz = XColor.FromArgb(255, 240, 225);

        private const double Vasak = 45;
        private const double Parem = 550;

        private static readonly double[] Veerg = { Vasak, 75, 320, 390, 470 };

        public static void Loo(string failitee, string arveNr, MakseAndmed makse, IReadOnlyList<OstukorviRida> read)
        {
            var dokument = new PdfDocument();
            dokument.Info.Title = $"Arve {arveNr}";
            dokument.Info.Author = MyyjaNimi;

            var fPealkiri = Font(26, XFontStyle.Bold);
            var fPais = Font(9, XFontStyle.Bold);
            var fTavaline = Font(9, XFontStyle.Regular);
            var fVaike = Font(8, XFontStyle.Regular);
            var fKokku = Font(12, XFontStyle.Bold);

            var lk = dokument.AddPage();
            var g = XGraphics.FromPdfPage(lk);

            g.DrawString("ARVE", fPealkiri, new XSolidBrush(Oranz), Vasak, 75);
            g.DrawString($"Arve nr: {arveNr}", fTavaline, XBrushes.Black, Vasak, 98);
            g.DrawString($"Kuupäev: {DateTime.Now:dd.MM.yyyy HH:mm}", fTavaline, XBrushes.Black, Vasak, 112);

            JoonistaLogo(g, Parem, 40, 150);

            double y = 145;
            g.DrawLine(new XPen(Oranz, 2), Vasak, y, Parem, y);

            y += 22;
            g.DrawString("MÜÜJA", fPais, new XSolidBrush(Hall), Vasak, y);
            g.DrawString("OSTJA", fPais, new XSolidBrush(Hall), 320, y);
            y += 16;
            g.DrawString(MyyjaNimi, fPais, XBrushes.Black, Vasak, y);

            double yOstja = y;
            foreach (var (tekst, font) in new[] { (makse.Nimi, fPais), (makse.Aadress, fTavaline), (makse.Email, fTavaline) })
            {
                foreach (var rida in Murra(g, tekst, font, Parem - 320))
                {
                    g.DrawString(rida, font, XBrushes.Black, 320, yOstja);
                    yOstja += 14;
                }
            }

            y = Math.Max(y + 14, yOstja) + 20;

            y = TabeliPais(g, fPais, y);
            int nr = 1;
            foreach (var r in read)
            {
                if (y > 740)
                {
                    lk = dokument.AddPage();
                    g.Dispose();
                    g = XGraphics.FromPdfPage(lk);
                    y = TabeliPais(g, fPais, 50);
                }

                if (nr % 2 == 0)
                    g.DrawRectangle(new XSolidBrush(HeleOranz), Vasak, y, Parem - Vasak, 20);

                double ty = y + 14;
                g.DrawString(nr.ToString(), fTavaline, XBrushes.Black, Veerg[0] + 5, ty);
                g.DrawString(Lyhenda(g, r.Toode.Toodenimetus, fTavaline, Veerg[2] - Veerg[1] - 10), fTavaline, XBrushes.Black, Veerg[1], ty);
                Paremale(g, $"{r.Kogus} tk", fTavaline, Veerg[3] - 10, ty);
                Paremale(g, $"{r.Toode.Hind:0.00} €", fTavaline, Veerg[4] - 10, ty);
                Paremale(g, $"{r.Summa:0.00} €", fTavaline, Parem - 5, ty);

                y += 20;
                nr++;
            }
            g.DrawLine(new XPen(XColor.FromArgb(200, 200, 200), 0.7), Vasak, y, Parem, y);

            if (y > 680)
            {
                lk = dokument.AddPage();
                g.Dispose();
                g = XGraphics.FromPdfPage(lk);
                y = 50;
            }

            decimal kokku = Math.Round(read.Sum(r => (decimal)r.Toode.Hind * r.Kogus), 2);
            decimal km = Math.Round(kokku * KaibemaksProtsent / (100 + KaibemaksProtsent), 2);

            y += 22;
            SummaRida(g, "Summa ilma käibemaksuta:", $"{kokku - km:0.00} €", fTavaline, y);
            y += 16;
            SummaRida(g, $"Käibemaks {KaibemaksProtsent:0}%:", $"{km:0.00} €", fTavaline, y);
            y += 10;
            g.DrawLine(new XPen(Oranz, 1.2), 330, y, Parem, y);
            y += 20;
            SummaRida(g, "KOKKU:", $"{kokku:0.00} €", fKokku, y);

            y += 40;
            g.DrawString("MAKSE", fPais, new XSolidBrush(Hall), Vasak, y);
            y += 16;
            g.DrawString("Makseviis:", fTavaline, XBrushes.Black, Vasak, y);
            g.DrawString(makse.KaartArvel, fPais, XBrushes.Black, Vasak + 75, y);
            y += 14;
            g.DrawString("Staatus:", fTavaline, XBrushes.Black, Vasak, y);
            g.DrawString("Makstud", fPais, new XSolidBrush(XColor.FromArgb(0, 128, 0)), Vasak + 75, y);
            y += 14;
            g.DrawString("Makse kuupäev:", fTavaline, XBrushes.Black, Vasak, y);
            g.DrawString($"{DateTime.Now:dd.MM.yyyy}", fTavaline, XBrushes.Black, Vasak + 75 + 20, y);

            double jy = lk.Height.Point - 45;
            g.DrawLine(new XPen(XColor.FromArgb(200, 200, 200), 0.7), Vasak, jy - 14, Parem, jy - 14);
            g.DrawString("Täname ostu eest!", fVaike, new XSolidBrush(Hall),
                new XRect(Vasak, jy - 8, Parem - Vasak, 12), XStringFormats.TopCenter);

            g.Dispose();
            dokument.Save(failitee);
        }

        private static XFont Font(double suurus, XFontStyle stiil) =>
            new XFont("Verdana", suurus, stiil, new XPdfFontOptions(PdfFontEncoding.Unicode));

        private static double TabeliPais(XGraphics g, XFont font, double y)
        {
            g.DrawRectangle(new XSolidBrush(Oranz), Vasak, y, Parem - Vasak, 22);
            double ty = y + 15;
            g.DrawString("Nr", font, XBrushes.White, Veerg[0] + 5, ty);
            g.DrawString("Toode", font, XBrushes.White, Veerg[1], ty);
            Paremale(g, "Kogus", font, Veerg[3] - 10, ty, XBrushes.White);
            Paremale(g, "Ühiku hind", font, Veerg[4] - 10, ty, XBrushes.White);
            Paremale(g, "Summa", font, Parem - 5, ty, XBrushes.White);
            return y + 22;
        }

        private static void SummaRida(XGraphics g, string silt, string vaartus, XFont font, double y)
        {
            Paremale(g, silt, font, 455, y);
            Paremale(g, vaartus, font, Parem - 5, y);
        }

        private static void Paremale(XGraphics g, string tekst, XFont font, double paremServ, double y, XBrush? pintsel = null)
        {
            double laius = g.MeasureString(tekst, font).Width;
            g.DrawString(tekst, font, pintsel ?? XBrushes.Black, paremServ - laius, y);
        }

        private static string Lyhenda(XGraphics g, string tekst, XFont font, double maxLaius)
        {
            if (g.MeasureString(tekst, font).Width <= maxLaius) return tekst;
            while (tekst.Length > 1 && g.MeasureString(tekst + "…", font).Width > maxLaius)
                tekst = tekst[..^1];
            return tekst + "…";
        }

        private static IEnumerable<string> Murra(XGraphics g, string tekst, XFont font, double maxLaius)
        {
            string rida = "";
            foreach (var sona in tekst.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                string proov = rida.Length == 0 ? sona : rida + " " + sona;
                if (rida.Length > 0 && g.MeasureString(proov, font).Width > maxLaius)
                {
                    yield return rida;
                    rida = sona;
                }
                else
                {
                    rida = proov;
                }
            }
            if (rida.Length > 0)
                yield return Lyhenda(g, rida, font, maxLaius);
        }

        private static void JoonistaLogo(XGraphics g, double paremServ, double y, double laius)
        {
            string tee = Path.Combine(Pildid.Kaust, "waurma.png");
            if (!File.Exists(tee))
                tee = Path.Combine(AppContext.BaseDirectory, "Images", "waurma.png");

            byte[] baidid;
            if (File.Exists(tee))
            {
                baidid = File.ReadAllBytes(tee);
            }
            else
            {
                using var ms = new MemoryStream();
                Properties.Resources.waurma.Save(ms, ImageFormat.Png);
                baidid = ms.ToArray();
            }

            using XImage logo = XImage.FromStream(() => new MemoryStream(baidid));
            double korgus = laius * logo.PixelHeight / logo.PixelWidth;
            g.DrawImage(logo, paremServ - laius, y, laius, korgus);
        }
    }
}
