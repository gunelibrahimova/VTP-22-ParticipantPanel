using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using ParticipantPanel.Models;
using ParticipantPanel.ViewModels;
using Services;
using System.Diagnostics;

namespace ParticipantPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CountServices _countServices;
        private readonly ItWEBServices _itWebServices;
        private readonly HRServices _hRServices;
        private readonly LPServices _lpServices;
        private readonly AFServices _AFServices;
        public HomeController(ILogger<HomeController> logger, CountServices countServices, ItWEBServices itWebServices, HRServices hRServices, LPServices lpServices, AFServices aFServices)
        {
            _logger = logger;
            _countServices = countServices;
            _itWebServices = itWebServices;
            _hRServices = hRServices;
            _lpServices = lpServices;
            _AFServices = aFServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<int> ages = new List<int>();
            List<int> ageCounts = new List<int>();

            HomeVM homeVM = new()
            {
                Itweb = _itWebServices.GetAll(),
                itWebCount = _itWebServices.GetCount(),
                lpcount = _lpServices.GetCount(),
                afcount = _AFServices.GetCount(),
                humenCount = _hRServices.GetCount(),
                logistics = _lpServices.GetAll(),
                ages = ages,
                ageCounts = ageCounts
            };
            

            foreach (AgePercentage item in _itWebServices.GetAgePercentage())
            {
                ages.Add(item.Age);
                ageCounts.Add(item.AgeCount);
            }
            
            return View(homeVM);
        }

        public IActionResult Privacy()
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