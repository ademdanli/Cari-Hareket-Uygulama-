using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewCari.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCari.Core.Config
{
    public class AdresConfig : BaseConfig<Adres>
    {
        public override void Configure(EntityTypeBuilder<Adres> builder)
        {
            base.Configure(builder);
            // Adres entity'e özel konfigürasyonlar buraya eklenebilir
        }
    }
}
