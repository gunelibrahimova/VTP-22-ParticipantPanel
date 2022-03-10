using Entities;
using Microsoft.AspNetCore.Mvc;
using ParticipantPanel.ViewModels;
using Services;

namespace ParticipantPanel.Controllers
{
    public class LPController : Controller
    {
        private readonly LPServices _services;

        public LPController(LPServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                logistics = _services.GetAll()
            };
            return View(homeVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string surname, int age, string gender, string faculty, string university, string department)
        {
            Logistic logistic = new()
            {
                Name = name,
                Surname = surname,
                Age = age,
                Gender = gender,
                Faculty = faculty,
                University = university,
                Department = department
            };

            _services.Create(logistic);


            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _services.Delete(id);

            return RedirectToAction(nameof(Index));
        }


    }
}
