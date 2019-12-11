using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app.Models;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MatchPage(UserModel model)
        {
            Dictionary<UserModel, int> ResultUsers = new Dictionary<UserModel, int>();
            if (model.Algorithm)
            {
                ResultUsers = new AlgorithmsClass().AdvancedAlgorithm(model);
               
            }
            else
            {
                ResultUsers = new AlgorithmsClass().DefaultAlgorithm(model);
            }
            return View(ResultUsers);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact(string name)
        {
            return View("Contact", name);
        }

        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult FindUsersPage()
        {
            List<UserModel> DummieList = new UserDummies().GetUserDummies();
            return View(DummieList);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
