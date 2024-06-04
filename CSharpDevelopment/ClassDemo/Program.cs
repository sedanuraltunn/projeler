using ClassDemo;

var mathHelper = new MathHelper();

//Demo(mathHelper);


mathHelper.DortIslem(10,2,out int toplama,out _, out _, out double bolme);
Console.WriteLine(toplama);

var deger=Console.ReadLine();
mathHelper.SayisalMi(deger,out string sonuc);
Console.WriteLine(sonuc);

Console.WriteLine(mathHelper.FaktoriyelRecur(3));

static void Demo(MathHelper mathHelper)
{
    var bilgisayar = new Urun
    {
        Ad = "Asus",
        StokBilgisi = 500,
        Fiyat = 15_000.0m
    };

    //var cumle = Console.ReadLine();
    //var kelime = cumle.Split(" ") ;

    //string ilkKelime = "";
    //string dizi = "";

    //for (int i = 0; i < kelime.Count(); i++)
    //{
    //    ilkKelime = kelime[i].Replace(" ","");
    //    dizi += ilkKelime[0].ToString().ToUpper();
    //    for (int j = 1; j < ilkKelime.Count(); j++)
    //    {

    //        dizi += ilkKelime[j].ToString().ToLower();
    //    }

    //    dizi += ' ';
    //}
    //Console.WriteLine(dizi);


    Console.WriteLine(mathHelper.KareAl(3));
    Console.WriteLine(mathHelper.OrtamaAl(3, 2));

    var dizi = new int[] { 1, 2, 4 };
    Console.WriteLine(mathHelper.OrtalamaAl(dizi));

    //var sayiList=new List<int>();
    //while (true)
    //{
    //    var girilenDeger = Console.ReadLine();
    //    Console.WriteLine("Sayı giriniz: ");
    //    sayiList.Add(int.Parse(girilenDeger));
    //}
    var carpimSonuc = mathHelper.Carp(2, 3, 6);
}
 