using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal static class MathHelper
    {
        static MathHelper()
        {
            Console.WriteLine("ctor oluşştu");
        }
        public static double PiSayisiGetir => 3.1415;
        public static double OrtalamaAl(int birinciSayi, int ikinciSayi) => (birinciSayi + ikinciSayi) / 2d;
        public static int KareAl(int sayi) => sayi * sayi;

        public static double OrtalamaAl(int[] sayilar)
        {
            double toplam = 0d;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam / sayilar.Length;
        } 
    }
}
