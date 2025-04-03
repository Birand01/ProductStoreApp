using System.Linq.Expressions;

namespace Repositories
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        T? FindByCondition(Expression<Func<T,bool>> expression,bool trackChanges);
    }




}