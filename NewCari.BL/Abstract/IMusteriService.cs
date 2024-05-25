using NewCari.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewCari.BLL.Abstract
{
    public interface IMusteriService
    {
        List<Musteri> GetAll();
        Musteri GetById(int id);
        void Add(Musteri musteri);
        void Update(Musteri musteri);
        void Delete(int id);
    }
}
