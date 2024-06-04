namespace NullableTypeDemo;

internal class Program
{
    static void Main(string[] args)
    {
        string isim = null;

        int? sayi = null;

        if (sayi.HasValue)
        {
            int deger = sayi.Value;
        }
        if (sayi == null) 
        { }
    }

}

