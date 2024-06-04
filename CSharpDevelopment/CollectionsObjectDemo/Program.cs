using System.Collections;

ArrayList isimler = new()
  {
      "Seda",
      "Veli",
      "Ali"
  };

Console.WriteLine("Konuşanlar : {0} ", string.Join(", ", isimler.ToArray())); 
 
    