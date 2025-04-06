using Entities.Models;

namespace Repositories
{
    public interface IProductRepository:IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
        Product? GetOneProduct(int id,bool trackChanges);

        void CreateOneProduct(Product product);
        void DeleteOneProduct(Product product);
    }
}