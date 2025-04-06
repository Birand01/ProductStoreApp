using Entities.Models;

namespace Repositories
{
    public interface IProductRepository:IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
        Product? GetOneProduct(int id,bool trackChanges);

        void CreateProduct(Product product);
    }
}