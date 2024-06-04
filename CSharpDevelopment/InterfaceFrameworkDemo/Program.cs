using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var msbList=new MsbList();
            msbList.Ekle("Seda");
            msbList.Ekle("Nur");
            msbList.Ekle("Altun");
            
            Console.WriteLine(msbList.ElemanSayisi);
            

            Console.WriteLine(msbList[1]);
            msbList.Sil(2);
            Console.WriteLine(msbList.ElemanSayisi);

            Console.ReadLine();
        }
    }
}
