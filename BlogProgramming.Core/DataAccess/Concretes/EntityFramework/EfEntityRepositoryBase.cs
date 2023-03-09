using BlogProgramming.Core.DataAccess.Abstract;
using BlogProgramming.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Core.DataAccess.Concretes.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
               await context.Set<TEntity>().AddAsync(entity);

            }
            
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using(TContext context = new TContext())
            {
                return await context.Set<TEntity>().AnyAsync(predicate);
            }
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().CountAsync(predicate);
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                await Task.Run(() => { context.Set<TEntity>().Remove(entity); });
            }
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
          
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> queryable = context.Set<TEntity>();
                if (predicate != null)
                {
                    queryable = queryable.Where(predicate);
                }
                if(includeProperties != null)
                {
                    foreach (var property in includeProperties)
                    {
                        queryable = queryable.Include(property);
                    }
                }
                return await queryable.ToListAsync();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> queryable = context.Set<TEntity>();
                if (predicate != null)
                {
                    queryable = queryable.Where(predicate);
                }
                if (includeProperties != null)
                {
                    foreach (var property in includeProperties)
                    {
                        queryable = queryable.Include(property);
                    }
                }
                return await queryable.SingleOrDefaultAsync();
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                await Task.Run(() => { context.Set<TEntity>().Update(entity); });
            }
        }
    }
}
