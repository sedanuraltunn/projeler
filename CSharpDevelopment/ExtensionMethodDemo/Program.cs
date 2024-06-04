using ExtensionMethodDemo;

var random=new Random();
for (int i = 0; i < 10; i++)
{
    var randomSayi = random.TekSayiUret(1,200); 
    Console.WriteLine(randomSayi);
}