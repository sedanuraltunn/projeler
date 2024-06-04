using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class RandomHelper
    {
        public static int TekSayiUret(this Random random, int min, int max)
        {
            var randomSayi = random.Next(min, max);
            if (randomSayi % 2 == 0)
            {
                return randomSayi++;
            }
            return randomSayi;
        }
        
    }
}
