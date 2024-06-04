using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class MsbList
    {
        public static int MaxElemanSayisi { get; set; } = 100;
        public int ElemanSayisi { get;}
        public void Ekle(object eleman)
        {
            if (ElemanSayisi>=MaxElemanSayisi)
             throw new Exception("Liste max eleman sayısına ulaştı");
        }
    }
}
