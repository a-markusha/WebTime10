using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebTime10.Models;

namespace WebTime10.Controllers
{

    public class HallController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Edit()
        {
            return View();
        }
        

    }
}
