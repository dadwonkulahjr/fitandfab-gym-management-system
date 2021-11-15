using FitAndFabulous.DataAccess.Services.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository
{
    public class DefaultRepository<TEntity> : IDefaultRepository<TEntity> where TEntity : class
    {
        internal DbContext _dbContext;
        internal DbSet<TEntity> _dbSet;
        public DefaultRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public TEntity Get(int id)
        {
            var findEntityFirst =  _dbSet.Find(id);

            if (findEntityFirst != null)
            {
                return findEntityFirst;
            }

            return null;
        }
        public IEnumerable<TEntity> GetMatchingEntityType(Expression<Func<TEntity, bool>> filterEntity = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderEntityBy = null, string navigationProperty = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filterEntity != null)
            {
                query = query.Where(filterEntity);
            }

            if (navigationProperty != null)
            {
                foreach (var property in navigationProperty.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }


            if (orderEntityBy != null)
            {
                return orderEntityBy(query).ToList();
            }

            return  query.ToList();

        }
    }
}
