using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class MemoryCache : ICacheService
    {
        public void Add(string key, object data)
        {
            Console.WriteLine("memory cache ile eklendi"); 
        }

        public object Get(string key)
        {
            Console.WriteLine("memory cache ile getirildi");
            return null;
        }

        public bool IsExist(string key)
        {
            return false;
        }

        public void Remove(string key)
        {
            Console.WriteLine("memory cache ile silindi");
        }
    }
}
