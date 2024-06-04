using ModelDemo;
 
var ogr = new Ogrenci()
{
    AdSoyad = "Seda Nur ALTUN",
    Yas = 25,
    OkulBilgi = new Okul()
    {
        OkulAdi = "Gazi Üniversitesi",
        OgrenimDurum = "Lisans",
        Sehir = "Ankara"
    },
    Dersler = new List<Ders>()
    {
        new Ders
        {
        Adi = "Veri Yapıları",
        DersKredi = 3
        },
        new Ders
        {
        Adi = "Veritabanı",
        DersKredi = 5
        }
    }
};
 

 