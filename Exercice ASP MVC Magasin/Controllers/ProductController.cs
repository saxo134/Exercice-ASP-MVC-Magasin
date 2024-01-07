using Exercice_ASP_MVC_Magasin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercice_ASP_MVC_Magasin.Controllers
{
    public class ProductController : Controller
    {
        // GET
        [Route("/")]
        public IActionResult Index()
        {
            return View(Repository.Products);
        }
    }
}
