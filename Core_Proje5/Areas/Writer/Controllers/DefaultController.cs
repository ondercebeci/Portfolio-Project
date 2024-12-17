using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementMenager announcementMenager = new AnnouncementMenager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcementMenager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
           Announcement announcement = announcementMenager.GetByID(id);
            return View(announcement);
        }
        
    }
}
