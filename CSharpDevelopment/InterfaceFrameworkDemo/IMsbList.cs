using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFrameworkDemo
{
    public interface IMsbList
    {
        void Ekle(object eleman);
        void Sil(int indexNo);
        int ElemanSayisi { get; }
        object this[int index]
        {
            get;
            set;
        }
    }
}
