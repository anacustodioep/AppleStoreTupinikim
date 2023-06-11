using Microsoft.AspNetCore.Mvc;

namespace AppleStoreTupinikim.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

    }
}
