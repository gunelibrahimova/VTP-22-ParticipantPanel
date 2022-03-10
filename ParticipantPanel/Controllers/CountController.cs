using Microsoft.AspNetCore.Mvc;
using ParticipantPanel.ViewModels;
using Services;

namespace ParticipantPanel.Controllers
{
    public class CountController : Controller
    {
        private readonly CountServices _services;

        public CountController(CountServices services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
