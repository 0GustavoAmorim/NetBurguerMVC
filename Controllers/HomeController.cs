using Microsoft.AspNetCore.Mvc;
using NetBurguer.Models;
using System.Diagnostics;

namespace NetBurguer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}