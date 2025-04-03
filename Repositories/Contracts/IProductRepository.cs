using Entities.Models;

namespace Repositories
{
    public interface IProductRepository:IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
    }
}