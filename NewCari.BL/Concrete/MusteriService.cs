using NewCari.BLL.Abstract;
using NewCari.Core.DataAccess;
using NewCari.Core.Concrete;
using NewCari.DAL.Abstract;

namespace NewCari.BLL.Concrete
{
    public class MusteriService : IMusteriService
    {
        private readonly IEntityRepository<Musteri> _musteriDal;

        public MusteriService(IEntityRepository<Musteri> musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public void Add(Musteri musteri)
        {
            _musteriDal.Add(musteri);
        }

        public List<Musteri> GetAll()
        {
            var result = _musteriDal.GetAll();
            return result ?? new List<Musteri>();
        }

        public Musteri GetById(int id)
        {
            return _musteriDal.Get(m => m.Id == id);
        }

        public void Update(Musteri musteri)
        {
            _musteriDal.Update(musteri);
        }

        public void Delete(int id)
        {
            var musteri = _musteriDal.Get(m => m.Id == id);
            if (musteri != null)
            {
                _musteriDal.Delete(musteri);
            }
        }
    }
}
