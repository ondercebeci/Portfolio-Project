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
    public class ServiceController : Controller
    {
        ServiceMenager serviceMenager = new ServiceMenager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = serviceMenager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceMenager.TAdd(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceMenager.GetByID(id);
            serviceMenager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = serviceMenager.GetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceMenager.TUpdate(service);
            return RedirectToAction("Index");

        }
    }
}
