using Microsoft.AspNetCore.Mvc;

namespace Assignment01_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var result = new ContentResult();
            //result.Content = "hello from index page ";
            //result.StatusCode = StatusCodes.Status200OK;
            //result.ContentType = "text/html";
            //return result;
            return View();
        }

        public RedirectResult Update()
        {
            var result = new RedirectResult("https://www.google.com");
            return result;
        }

        public RedirectToActionResult Add()
        {
            var result = new RedirectToActionResult(nameof(ProductsController.Add), "Products", new { id = 1 });
            return result;



        }

        public IActionResult  Privacy()
        {
            return View();
        
         
        }

    }
}
