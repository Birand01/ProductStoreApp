using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreApp.Components
{
    public class ProductSummary:ViewComponent
    {
        private readonly RepositoryContext repositoryContext;

        public ProductSummary(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }
        public String Invoke()
        {
            return repositoryContext.Products.Count().ToString();
        }
    }
}