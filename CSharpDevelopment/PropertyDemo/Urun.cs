 
namespace PropertyDemo;

internal class Urun
{
    public string Adi { get; set; } = null!;
    public decimal BirimFiyati { get; set; }
    public int StokMiktari { get; init; } // c# 9.0
    public string Aciklama { get; set; } =string.Empty;
    public string? Tedarikci { get; set; } // yalnızca farkındalığı artırmak için string? şeklinde kullanıldı.
}
