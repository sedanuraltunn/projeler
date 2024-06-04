

using ExceptionHandlingDemo;

try
{
    Console.Write("Bölüm giriniz:");
    int bolum = int.Parse(Console.ReadLine());
    Console.Write("Bölen giriniz:");
    int bolen = int.Parse(Console.ReadLine());
    if (bolen==0)
    {
        throw new MsbException("Bölen 0 olamaz");
    }
    var sonuc = bolum / bolen;
    Console.WriteLine(sonuc);

}
//catch (FormatException)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Sayısal değer giriniz");
//}
catch (MsbException e)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Beklenmedik hata oluştu");
}

finally //hata olsa da olmasa da çalışır
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Bitti");
}

