using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Controllers
{
    public class SkillController : Controller
    {
        SkillMenager skillMenager = new SkillMenager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillMenager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillMenager.TAdd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillMenager.GetByID(id);
            skillMenager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = skillMenager.GetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillMenager.TUpdate(skill);
            return RedirectToAction("Index");

        }
    }
}
