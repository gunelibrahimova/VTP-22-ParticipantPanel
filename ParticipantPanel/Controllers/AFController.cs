using Entities;
using Microsoft.AspNetCore.Mvc;
using ParticipantPanel.ViewModels;
using Services;

namespace ParticipantPanel.Controllers
{
    public class AFController : Controller
    {
        private readonly AFServices _context;

        public AFController(AFServices context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                afDeps = _context.GetAll()
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
            AfDep afDep = new()
            {
                Name = name,
                Surname = surname,
                Age = age,
                Gender = gender,
                Faculty = faculty,
                University = university,
                Department = department

            };

            _context.Create(afDep);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _context.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
