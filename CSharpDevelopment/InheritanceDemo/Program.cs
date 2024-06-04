using InheritanceDemo;

var ogrenci = new Ogrenci() 
{ 
    AdiSoyadi = "Seda Nur ALTUN", 
    Yas = 23, 
    OkulNo = "3", 
    TcNo = "11111111111" 
};

var ogretmen= new Ogretmen () 
{ 
    AdiSoyadi = "Ali VELİ", 
    Yas = 40, 
    TcNo = "11111111111", 
    Maas= 65_000 
};

static void BilgileriYazdir(Kisi kisi)
{
    Console.WriteLine("Adı Soyadı : {0}", kisi.AdiSoyadi);
    Console.WriteLine("Yas : {0}", kisi.Yas);
    Console.WriteLine("TCNo : {0}", kisi.TcNo);

    //if (kisi is Ogrenci)
    //{
    //    var ogrencim = (Ogrenci)kisi;
    //    Console.WriteLine(ogrencim.OkulNo);
    //}
    if (kisi is Ogrenci ogrencim)
            Console.WriteLine(ogrencim.OkulNo);

    Ogretmen ogretmenim = kisi as Ogretmen; //cast ile farkı tip dönüşümü yapamazsa hata vermez değeri nulla set eder
    if (ogretmenim is not null)
    {
        Console.WriteLine(ogretmenim.Maas);
    }
    
}
 