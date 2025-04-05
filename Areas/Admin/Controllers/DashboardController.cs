using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Controllers
{

    [Area("Admin")]
    public class DashboardController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}