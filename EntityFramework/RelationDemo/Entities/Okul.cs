using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationDemo.Entities
{
    public enum OgretimDuzeyi
    {
        IlkOgretim = 1,
        OnLisans =2,
        Lisans=3
    }
    public class Okul
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Adres { get; set; } = null!;
        public OgretimDuzeyi OgretimDuzeyi { get; set; }
        public ICollection<Ogrenci>? Ogrenciler { get; set; }
    }
}
