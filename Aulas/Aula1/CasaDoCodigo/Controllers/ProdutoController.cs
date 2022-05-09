using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult CadastroProduto()
        {
            return View();
        }
    }
}
