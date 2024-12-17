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
    public class TestimonialController : Controller
    {
        TestimonialMenager testimonialMenager = new TestimonialMenager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialMenager.TGetList();
            return View(values);
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialMenager.GetByID(id);
            testimonialMenager.TDelete(values);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values = testimonialMenager.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            testimonialMenager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
