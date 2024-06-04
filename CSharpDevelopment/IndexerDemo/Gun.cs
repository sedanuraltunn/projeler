namespace IndexerDemo;

internal class Gun
{
    private string[] _gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar", };
    public string this[byte haftaninGunu]
    {
        get
        {
            //switch (haftaninGunu)
            //{
            //	case 1: 
            //		return "Pazartesi";
            //             case 2:
            //                 return "Salı";
            //             case 3:
            //                 return "Çarşamba";
            //             case 4:
            //                 return "Perşembe"; 
            //             case 5:
            //                 return "Cuma"; 
            //             case 6:
            //                 return "Cumartesi";
            //             case 7:
            //                 return "Pazar";
            //             default:
            //                 throw new Exception("Haftanın günü 1-7 arasında olmalı");      
            //}

            //return haftaninGunu switch //exp bodied
            //{
            //    1 => "Pazartesi",
            //    2 => "Salı",
            //    3 => "Çarşamba",
            //    4 => "Perşembe",
            //    5 => "Cuma",
            //    6 => "Cumartesi",
            //    7 => "Pazar",
            //};
            if (haftaninGunu < 0 || haftaninGunu > 7)
            {
                throw new Exception("Haftanın günü 1-7 arasında olmalı");
            }
            return _gunler[haftaninGunu - 1];
        }
    }
}
