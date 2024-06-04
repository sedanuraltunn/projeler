using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class MathHelper
    {
        public double OrtamaAl(int birinciSayi, int ikinciSayi) => (birinciSayi + ikinciSayi) / 2d;
        public int KareAl(int sayi) => sayi * sayi;

        public double OrtalamaAl(int[] sayilar)
        {
            double toplam = 0d;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam+=sayilar[i];
            }
            return toplam/sayilar.Length;
        }
        public long Carp(byte a, byte b, byte c, byte d=1)
        {
            return a * b * c * d;
        }


        public void DortIslem(int a, int b, out int toplama, out int cikarma, out long carpma, out double bolme) 
        {
            toplama = a + b;
            cikarma = a - b;
            carpma = a * b;
            bolme = a / (double)b;
        }
        public void SayisalMi(string a, out string sonuc)
        {
            if (double.TryParse(a,out double sayi))
            {
                sonuc = (sayi / 2).ToString();
            }
            else
            {
                sonuc = "Bu bir sayısal değer değil";
            }
        }
        public int FaktoriyelRecur(int sayi)
        { 
            if (sayi==0)
            {
                return 1;
            }
            return sayi * FaktoriyelRecur(sayi - 1);

        }
    }
}
