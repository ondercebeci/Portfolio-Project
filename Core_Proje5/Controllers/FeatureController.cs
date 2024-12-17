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
    public class FeatureController : Controller
    {
        FeatureMenager featureMenager = new FeatureMenager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = featureMenager.GetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureMenager.TUpdate(feature);
            return RedirectToAction("Index","Default");

        }
    }
}
