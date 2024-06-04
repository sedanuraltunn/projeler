namespace PolymorphismDemo;

//inheritanceDemo projesi Program.cs altındaki BilgiYazdir metodu nesne yönelimli programlamaya uygun hale getirilmiştir. (SOLID open-close principle)
internal class Kisi
{
    public string AdiSoyadi { get; set; }
    public virtual int Yas { get; set; }
    public string TcNo { get; set; }

    public virtual void BilgiYazdir()
    {
        Console.WriteLine("******************************************************");
        Console.WriteLine("Adı Soyadı : {0}", AdiSoyadi);
        Console.WriteLine("Yas : {0}", Yas);
        Console.WriteLine("TCNo : {0}", TcNo);
    }
}
internal class Ogrenci : Kisi
{
    public string OkulNo { get; set; }

    public override string ToString()
    {
        return $"{AdiSoyadi} - {Yas}";

    }
    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine("Okul No : {0}", OkulNo);
    }
}
internal class Ogretmen : Kisi
{
    public decimal Maas { get; set; }

    public override int Yas 
    { 
        get => base.Yas; 
        set 
        {
            if (value<25) 
                throw new Exception("Öğretmen yaşı 25'ten küçük olamaz."); 
            base.Yas = value;
        } 
    }
    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine("Maas : {0}", Maas);
    }
}
