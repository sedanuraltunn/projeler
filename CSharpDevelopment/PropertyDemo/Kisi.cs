namespace PropertyDemo;

internal class Kisi
{
    private string _adSoyad;
    private DateTime _dogumTarihi;

    public DateTime GetDogumTarihi() => _dogumTarihi;

    public void SetDogumTarihi(DateTime dogumTarihi) => _dogumTarihi=dogumTarihi;

    public int GetYas() => DateTime.Now.Year - _dogumTarihi.Year;
}
 
