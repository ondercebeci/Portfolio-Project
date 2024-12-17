using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutMenager aboutMenager = new AboutMenager(new EfAboutDal());

        public IViewComponentResult Invoke()
        {
            var values = aboutMenager.TGetList();
            return View(values);
        }
    }
}
