using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialMenager testimonialMenager = new TestimonialMenager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialMenager.TGetList();
            return View(values);
        }
    }
}
