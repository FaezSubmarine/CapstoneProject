using CapstoneProject.Models;
using CapstoneProject.Repository;
using CapstoneProject.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRecordRepository recordRepo;
        public IUserRepository _userRepository;
        public HomeController(IUserRepository _userRepository, IRecordRepository recordRepo,ILogger<HomeController> logger)
        {
            this.recordRepo = recordRepo;
            _logger = logger;
            this._userRepository = _userRepository;
        }

        public IActionResult Index()
        {
            return View(recordRepo.GetRequestRecords().Where(e=>e.timing!=null).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("book")]
        public IActionResult Book()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
