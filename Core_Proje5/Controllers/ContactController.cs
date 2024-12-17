using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Controllers
{
    public class ContactController : Controller
    {
        MessageMenager messageMenager = new MessageMenager(new EfMessageDal());
        public IActionResult Index()
        {
            var values= messageMenager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = messageMenager.GetByID(id);
            messageMenager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult ContactDetails(int id)
        {
            var values = messageMenager.GetByID(id);
            return View(values);

        }
    }
}
