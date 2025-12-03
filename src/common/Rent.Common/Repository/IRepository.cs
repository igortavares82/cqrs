namespace Rent.Common.Repository;

using System.Collections;
using System.Threading.Tasks;
using System.Linq.Expressions;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity> CreateAsync(TEntity entity);
    Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> expression, int limit = 100);
    Task<IEnumerable<XEntity>> GetAsync<XEntity>(Expression<Func<XEntity, bool>> expression);
    Task UpdateAsync(params TEntity[] entities);
    Task DeleteAsync(Expression<Func<TEntity, bool>> expression);
} 