using DelegateSample;

List<string> isimler = new List<string>
{ "Ali","Veli","Ayşe","Fatma","Alper","Özgür","Okan","Hakan","Seda","Ferhat"};

//List<string> besKarakterliIsimler = ListHelper.BesKarakterListele(isimler);
//Console.WriteLine(string.Join(", ", besKarakterliIsimler));
List<string> delege = ListHelper.Filtrele(isimler, t => t.Length == 5);
Console.WriteLine(string.Join(", ", delege));

//List<string> aHarfiGecenler = ListHelper.IcindeAOlanlarıListele(isimler);
//Console.WriteLine(string.Join(", ", aHarfiGecenler));
delege = ListHelper.Filtrele(isimler, t => t.ToLower().Contains("a"));
Console.WriteLine(string.Join(", ", delege));

//List<string> iIleBiten = ListHelper.IIleBitenListele(isimler);
//Console.WriteLine(string.Join(", ", iIleBiten));
delege = ListHelper.Filtrele(isimler, t => t.EndsWith("i"));
Console.WriteLine(string.Join(", ", delege));


