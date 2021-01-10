using Ecommerce.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.Core.DataAccess.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity:BaseEntity
        where TContext:DbContext
    {
        TContext context;
        public EFRepositoryBase()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContext<TContext>();
            ServiceProvider provider = services.BuildServiceProvider();
            context = provider.GetService<TContext>();
        }

        public void Add(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return context.Set<TEntity>().Where(filter).MyInclude(includes).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            if (filter == null)
            {
                return context.Set<TEntity>().MyInclude(includes).ToList();
            }
            else
            {
                return context.Set<TEntity>().Where(filter).MyInclude(includes).ToList();

            }
        }

      

    }
}
