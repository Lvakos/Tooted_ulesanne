namespace Tooted
{
    public static class AktiivneKasutaja
    {
        public static int Id { get; set; }
        public static string Nimi { get; set; }
        public static string Roll { get; set; }

        public static bool OnAdmin => Roll == "admin";
    }
}
