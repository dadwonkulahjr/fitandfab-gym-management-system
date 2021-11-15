using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FitAndFabulous.DataAccess.Services.Repository.IRepository
{
    public interface IDefaultRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetMatchingEntityType(Expression<Func<TEntity, bool>> filterEntity = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderEntityBy = null, string navigationProperty = null);

        TEntity Get(int id);
    }
}
