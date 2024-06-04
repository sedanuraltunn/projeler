using PropertyDemo;

var kisi = new Kisi();
kisi.SetDogumTarihi(new DateTime(1995,05,14));
Console.WriteLine("Doğum Tarihi {0}", kisi.GetDogumTarihi());
Console.WriteLine("Yaş {0}", kisi.GetYas());

var sahis=new Sahis();
sahis.AdSoyad = "Seda Nur Altun";
sahis.DogumTarihi = new DateTime(1995, 05, 14);
Console.WriteLine("AdSoyad {0}", sahis.AdSoyad);
Console.WriteLine("Doğum Tarihi {0}", sahis.DogumTarihi);
Console.WriteLine("Yaş {0}", sahis.Yas);

var urun=new Urun();
urun.Adi = "Bilgisayar";
//urun.StokMiktari = 100;
urun.BirimFiyati= 34_000;
urun.Aciklama = "16 gb ram ..";
urun.Tedarikci = null;

