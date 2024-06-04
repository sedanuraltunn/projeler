using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFrameworkDemo
{
    public class MsbGenericList<T> where T : class    // class kısıtı: T yalnızca referans tip olmalı anlamına gelir.
                                                         // struct kısıtı: T yalnızca değer tip olmalı anlamına gelir.
                                                         //new () kısıtı: T'nin mutlaka parametresiz bir contructor bloğu olmak zorunda
    {                                                   //ICollection : yalnızca ICollection'dan inherit edilenler kullanılabilir
        private T[] _dizi;
        public MsbGenericList()
        {
            _dizi = new T[0];
        }
        public T this[int index]
        {
            get => _dizi[index];
            set => _dizi[index] = value;
        }

        public int ElemanSayisi => _dizi.Length;

        public void Ekle(T eleman)
        {
            var yedekDizi = _dizi;
            _dizi = new T[ElemanSayisi + 1];
            yedekDizi.CopyTo(_dizi, 0);
            _dizi[ElemanSayisi - 1] = eleman;

        }

        public void Sil(int indexNo)
        {
            var yedekDizi = _dizi;
            _dizi = new T[ElemanSayisi - 1];

            var sayac = 0;
            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (indexNo == i)
                    continue;
                _dizi[sayac] = yedekDizi[i];
                sayac++;
            }
        }



    }
}
