using NewCari.Core.DataAccess.EntityFramework;
using NewCari.Core.Concrete;
using NewCari.DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace NewCari.DAL.Concrete.EntityFramework
{
    public class EfMusteriDal : EfEntityRepositoryBase<Musteri, NewCariDbContext>, IMusteriDAL
    {
        public IQueryable<Musteri> GetAllIncluding(NewCariDbContext newCariDbContext, params Expression<Func<Musteri, object>>[] includeProperties)
        {
            IQueryable<Musteri> query = newCariDbContext.Set<Musteri>();

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query;
        }

        public IQueryable<Musteri> GetAllIncluding(params Expression<Func<Musteri, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
