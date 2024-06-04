using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo;

//internal class Ogrenci
//{
//    public string AdiSoyadi { get; set; }
//    public int Yas { get; set; }
//    public string TcNo { get; set; }
//    public string OkulNo { get; set; }

//}

//internal class Ogretmen
//{
//    public string AdiSoyadi { get; set; }
//    public int Yas { get; set; }
//    public string TcNo { get; set; }
//    public decimal Maas { get; set; }

//}

internal class Kisi
{
    public string AdiSoyadi { get; set; }
    public int Yas { get; set; }
    public string TcNo { get; set; }


}
internal class Ogrenci :Kisi
{ 
    public string OkulNo { get; set; }

}

internal class Ogretmen : Kisi
{ 
    public decimal Maas { get; set; }

}
         
