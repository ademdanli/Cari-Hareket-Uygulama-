using NewCari.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCari.Core.Concrete
{
    public class Sehir : BaseEntity, IEntity
    {
        
        public int SehirId { get; set; }
        public string? SehirAdi { get; set; }
    }
}
