namespace PropertyDemo;
internal class Sahis
{
    private string _adSoyad;

    public string AdSoyad
    {
        //get { return _adSoyad; }
        //set { _adSoyad = value; }
        get => _adSoyad; // c# 7.0
        set => _adSoyad = value; //c# 7.0
    }
    public DateTime DogumTarihi { get; set; }
    public int Yas
    {
        get { return DateTime.Now.Year - DogumTarihi.Year; }
    }
    public string Adres { get; set; } = "Ankara"; // c# 6.0'da propertylere bu şekilde başlangıç değeri ataması yapılabilir.
    public int RandomSayi { get; } = Random.Shared.Next(1,100);
    public string BabaAdi { get; private set; } // get erişim belirteci alamaz, set alabilir. 
}
