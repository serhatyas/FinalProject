using Core.Abstract;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class denemeRepository<TEntity, TContext> : IEntityRepostory<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity Entity)
        {

            using (TContext context=new TContext())
            {
                var addedEntity = context.Entry(Entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(TEntity Entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context=new TContext())
            {
                throw new NotImplementedException();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}
