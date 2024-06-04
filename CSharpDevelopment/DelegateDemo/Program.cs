
using DelegateDemo;

//Demo1();

//Demo2();

//Demo3();

Action<string, bool, int, string> delege1; //sırasıyla string, bool, int, string parametre alan geriye değer döndürmeyen delege

Func<bool> delege2; //bool değer döndüren parametre almayan delege
Func<bool,string> delege3; //bool alan string döndüren delege
Console.WriteLine("Bitti");

void MerhabaDunya()
{
    Console.WriteLine("Merhaba Dünya");
}
void HelloWorld() => Console.WriteLine("Hello World");

void Demo1()
{
    Temsilci1 delege1 = MerhabaDunya;
    delege1 += HelloWorld;


    delege1 += () => Console.WriteLine("Günaydın");
    delege1 += () =>   //birden fazla satır varsa süslü parantez ile
    {
        int sayi = Random.Shared.Next(0, 10);
        Console.WriteLine(sayi);
    };


    delege1.Invoke(); //Değişkende hangi method varsa onu tetikler. veya delege1();
}

static void Demo2()
{
    Temsilci4 delege4 = MathHelper.KareAl;
    delege4 += sayi => sayi * sayi * sayi; // => sol tarafı parametre, sağ tarafı return 

    long sonuc = delege4.Invoke(5);
    Console.WriteLine(sonuc);

    Console.WriteLine("--------------------------------");
    foreach (var delege in delege4.GetInvocationList())
    {

    }
}

static void Demo3()
{
    Temsilci3 delege3 = new Temsilci3(MathHelper.Topla);
    delege3 += MathHelper.Carp;
    delege3 += (a, b) => a * b * 2;

    delege3 += (taban, us) =>
    {
        var sonuc = 1;
        for (int i = 1; i <= us; i++)
        {
            sonuc *= taban;
        }
        return sonuc;
    };
    var sonuc = delege3.Invoke(2, 3);
    Console.WriteLine(sonuc);
}