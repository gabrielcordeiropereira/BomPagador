using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BomPagador.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fornecedores()
        {
            return View();
        }
        public IActionResult Clientes()
        {
            return View();
        }
        public IActionResult Faturas()
        {
            return View();
        }
    }
}
