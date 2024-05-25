using NewCari.Core.Entities;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;





namespace NewCari.Core.Concrete
{

    public enum CariHareketTuru
    {
        AlınanBorc,
        VerilenBorc
    }
    public class Musteri : BaseEntity, IEntity
    {

        
        
        public CariHareketTuru carihareketturu { get; set; }
        public string MusteriIsmi { get; set; }
          public short IslemAdet { get; set; }
          public decimal Miktar { get; set; }
        

        //public ICollection<Sehir>? Sehirler { get; set; }

        //public ICollection<Adres>? Adresler { get; set; }



    }


}