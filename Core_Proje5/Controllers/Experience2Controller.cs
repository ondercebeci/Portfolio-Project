using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Controllers
{
    [AllowAnonymous]
    public class Experience2Controller : Controller
    {
        ExperienceMenager experienceMenager = new ExperienceMenager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceMenager.TGetList());
            return Json(values);
        }
        public IActionResult AddExperience(Experience p)
        {
            experienceMenager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult ZGetByID(int ExperienceID)
        {
            var v = experienceMenager.GetByID(ExperienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var v = experienceMenager.GetByID(id);
            experienceMenager.TDelete(v);
            return NoContent();

        }
    }
}
