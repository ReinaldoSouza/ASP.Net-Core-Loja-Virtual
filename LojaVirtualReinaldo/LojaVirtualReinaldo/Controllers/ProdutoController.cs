using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtualReinaldo.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Visualizar()
        {
            return View();
        }
    }
}
