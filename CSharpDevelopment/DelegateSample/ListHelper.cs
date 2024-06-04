using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    public class ListHelper
    {
        public static List<string> BesKarakterListele(List<string> data)
        {
            List<string> filtreliData = new List<string>();

            foreach (var isim in data)
            {
                if (isim.Length == 5)
                {
                    filtreliData.Add(isim);
                }
            }
            return filtreliData;
        }
        public static List<string> IcindeAOlanlarıListele(List<string> data)
        {
            List<string> filtreliData = new List<string>();

            foreach (var isim in data)
            {
                if (isim.ToLower().Contains("a"))
                {
                    filtreliData.Add(isim);
                }
            }
            return filtreliData;

        }
        public static List<string> IIleBitenListele(List<string> data)
        {
            List<string> filtreliData = new List<string>();

            foreach (var isim in data)
            {
                if (isim.ToLower().EndsWith("i"))
                {
                    filtreliData.Add(isim);
                }
            }
            return filtreliData;

        }
        public static List<string> Filtrele(List<string> data, Func<string, bool> kosul)
        {
            List<string> filtreliData = new List<string>();

            foreach (var isim in data)
            {
                if (kosul.Invoke(isim))
                {
                    filtreliData.Add(isim);
                }
            }
            return filtreliData;

        }
    }
}
