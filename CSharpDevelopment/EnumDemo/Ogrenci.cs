namespace EnumDemo;

enum OgretimDurumuEnum
{
    Ilkogretim,
    Lise,
    OnLisans,
    Lisans,
    YuksekLisans,
    Doktora
}
internal class Ogrenci
{
    public string AdSoyad { get; set; }
    public int Yas { get; set; }
    public Okul OkulBilgi { get; set; } 

}

internal class Okul
{
    public string OkulAdi { get; set; }
    public OgretimDurumuEnum OgrenimDurum { get; set; }
    public string Sehir { get; set; }
}
