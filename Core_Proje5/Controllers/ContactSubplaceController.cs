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
    public class ContactSubplaceController : Controller
    {
        ContactMenager contactMenager = new ContactMenager(new EfContactDal());
       
        [HttpGet]
            public IActionResult Index()
        {
            var values = contactMenager.GetByID( 1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactMenager.TUpdate(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
