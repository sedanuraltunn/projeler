using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo;
internal abstract class Kisi
{
    protected Kisi()
    {

    }
    public string AdiSoyadi { get; set; }
    public int Yas { get; set; }
    public string TcNo { get; set; }
    public abstract string Meslek { get;}
    public void BilgiYazdir()
    {
        Console.WriteLine("******************************************************");
        Console.WriteLine("Adı Soyadı : {0}", AdiSoyadi);
        Console.WriteLine("Yas : {0}", Yas);
        Console.WriteLine("TCNo : {0}", TcNo);
        Console.WriteLine("Meslek : {0}", Meslek);
        EkstraBilgiYazdir();
    }
    protected abstract void EkstraBilgiYazdir();
}
internal class Ogrenci : Kisi
{
    public string OkulNo { get; set; }
    public override string Meslek => "Öğrenci";
    protected override void EkstraBilgiYazdir()
    {
        Console.WriteLine("OkulNo : {0}", OkulNo);
    }
}

internal class Ogretmen : Kisi
{
    public decimal Maas { get; set; }
    public override string Meslek => "Öğretmen";
    protected override void EkstraBilgiYazdir()
    {
        Console.WriteLine("Maas : {0}", Maas);
    }
}

