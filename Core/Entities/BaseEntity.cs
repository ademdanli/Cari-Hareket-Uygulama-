using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCari.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        //public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}
