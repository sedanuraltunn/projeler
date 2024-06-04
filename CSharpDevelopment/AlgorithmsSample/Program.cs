//SayiToplam()
//AsalSayiar();
FaktoriyelHesapla();

static void SayiToplam()
{
    var toplam = 0;
    for (int i = 1; i < 100; i++)
    {
        toplam += i;
    }
    Console.WriteLine("Toplam : {0}", toplam);
}

static void AsalSayiar()
{
    for (int i = 2; i < 100; i++)
    {
        bool asalMi = true;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                asalMi = false;
                break;

            }
        }
        if (asalMi)
        {
            Console.WriteLine(i);
        }
    }
}

static void FaktoriyelHesapla()
{
    Console.Write("Bir sayı giriniz : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    long carpim = 1;
    for (int i = 1; i <= sayi; i++)
    {
        carpim *= i;
    }
    Console.WriteLine($"{sayi}! = {carpim}"); //string interpolation
    Console.WriteLine("{0}! = {1}",sayi,carpim); //string format
    Console.WriteLine("Faktöriyel: " + carpim);
}