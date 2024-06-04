var ogrenci = new
{
    AdSoyad="Seda Nur ALTUN",
    Yas=23,
    Cinsiyet='K'
};

var ogr = new 
{
    AdSoyad = "Seda Nur ALTUN",
    Yas = 25,
    OkulBilgi = new 
    {
        OkulAdi = "Gazi Üniversitesi",
        OgrenimDurum = "Lisans",
        Sehir = "Ankara"
    },
    Dersler = new[]
    {
        new 
        {
        Adi = "Veri Yapıları",
        DersKredi = 3
        },
        new 
        {
        Adi = "Veritabanı",
        DersKredi = 5
        }
    }
};