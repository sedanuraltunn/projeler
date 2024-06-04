using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface ICacheService
    {
        public void Add(string key, object data);
        public void Remove(string key);
        public object Get(string key);
        public bool IsExist(string key);
    }
}
