using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ProductSummaryViewComponent:ViewComponent
    {
        private readonly IServiceManager serviceManager;

        public ProductSummaryViewComponent(IServiceManager repositoryContext)
        {
            this.serviceManager = repositoryContext;
        }
        public String Invoke() // this method name is built in function name do not change it
        {
            return serviceManager.ProductService.GetAllProducts(false).Count().ToString();
        }
    }
}