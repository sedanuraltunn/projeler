 namespace DelegateDemo
{
    internal static class MathHelper
    { 
        public static double PiSayisiGetir() => 3.1415;
        public static double OrtalamaAl(int birinciSayi, int ikinciSayi) => (birinciSayi + ikinciSayi) / 2d;
        public static long KareAl(int sayi) => sayi * sayi;

        public static double OrtalamaAl(int[] sayilar)
        {
            double toplam = 0d;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam / sayilar.Length;
        }
        public static long Topla(int a, int b) => a + b;
        public static long Cikar(int a, int b) => a - b;
        public static long Carp(int a, int b) => a * b;
        public static double Bol(int a, int b) => a / b;
    }
}
