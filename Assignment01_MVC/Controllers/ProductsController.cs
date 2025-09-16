using Assignment01_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment01_MVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Add( int id)
        {
            var result = new ContentResult();
            result .Content = $"Done {id}" ;
            return result;
            //return View();
        }

        public string Create(int id , string name , Product product  )
        {
            return $"Product with id {id} :: Name {name}";
        }
    }
}
