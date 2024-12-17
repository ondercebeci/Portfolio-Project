using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.ViewComponents.Feature
{
    public class FeatureList: ViewComponent
    {
        FeatureMenager featureMenager = new FeatureMenager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureMenager.TGetList();
            return View(values);
        }
    }
}
