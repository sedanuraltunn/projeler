using EnumDemo;

var ogrenci = new Ogrenci()
{
    AdSoyad = "Seda Nur Altun",
    Yas = 25,
    OkulBilgi = new Okul
    {
        OkulAdi = "Gazi Üni.",
        Sehir = "Ankara",
        OgrenimDurum = OgretimDurumuEnum.Lisans
    }
};

Renk renk = Renk.Kirmizi | Renk.Turuncu;
Console.WriteLine(renk);

var renklist=Enum.GetNames<Renk>();
Console.WriteLine(string.Join(",",renklist));