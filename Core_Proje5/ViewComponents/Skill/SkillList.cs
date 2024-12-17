using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillMenager skillMenager = new SkillMenager(new EfSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = skillMenager.TGetList();
            return View(values);
        }
    }
}
