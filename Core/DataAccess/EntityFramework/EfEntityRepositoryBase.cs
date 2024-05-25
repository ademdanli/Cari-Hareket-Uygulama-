using Microsoft.EntityFrameworkCore;
using NewCari.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewCari.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>

        where TEntity : class, IEntity, new() //TEntity class olmalı , IEntity türünde olmalı , newlenebilmeli.

        where TContext : DbContext, new()  //TContext DbContext türünde olmalı , newlenebilmeli 

    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var existingEntity = context.Set<TEntity>().Find(entity.Id);
                if (existingEntity != null)
                {
                    context.Entry(existingEntity).CurrentValues.SetValues(entity);
                    context.SaveChanges();
                }
                else
                {
                    throw new DbUpdateConcurrencyException("Entity not found in the database.");
                }
            }
        }
    }
}
