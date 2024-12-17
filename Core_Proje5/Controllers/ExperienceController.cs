using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Controllers
{
    [Authorize(Roles ="admin")]
    public class ExperienceController : Controller
    {
        ExperienceMenager experienceMenager = new ExperienceMenager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experienceMenager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceMenager.TAdd(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceMenager.GetByID(id);
            experienceMenager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = experienceMenager.GetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceMenager.TUpdate(experience);
            return RedirectToAction("Index");

        }
    }
}
