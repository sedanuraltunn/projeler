using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationDemo.Entities
{
    public class OgrenciDetay
    {
        public int Id { get; set; }
        public Guid OgrenciId { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public string? DogumYeri { get; set; }

        public Ogrenci Ogrenci { get; set; } = null!;
    }
}
