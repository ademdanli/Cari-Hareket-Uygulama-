using Microsoft.EntityFrameworkCore;
using NewCari.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCari.DAL.Concrete
{
    public class NewCariDbContext : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; } // Define DbSet for Product entity
        //public DbSet<Sehir> Sehirler { get; set; }
        //public DbSet<Adres> Adresler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your connection string here
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RM72QHV;Database=NewCariUygulamaDb;Trusted_Connection=True;Trust Server Certificate=true");
        }



    }
}


