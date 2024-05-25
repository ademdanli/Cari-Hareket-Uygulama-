using NewCari.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCari.Core.Concrete
{
    public class Adres : BaseEntity, IEntity
    {
        
        // public int AdresId { get; set; }    
        public string? AdresAdi { get; set; }

        public int? MusteriId { get; set; }
        public Musteri? Musteri { get; set; }
        public int? SehirID { get; set; }
        public Sehir? Sehir { get; set; }
    }
}
