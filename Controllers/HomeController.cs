using Fiorello.DAL;
using Fiorello.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly FiorelloDbContext _FiorelloDbContext;
        public HomeController(FiorelloDbContext FiorelloDbContext)
        {
            _FiorelloDbContext=FiorelloDbContext;    
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}