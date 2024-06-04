using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationDemo.Entities
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public decimal KrediNotu { get; set; }
        public ICollection<Ogrenci>? Ogrenciler { get; set; }
    }
}
