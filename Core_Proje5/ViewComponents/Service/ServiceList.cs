using BusinessLayer.Concrate;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramework;

namespace Core_Proje5.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceMenager serviceMenager = new ServiceMenager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceMenager.TGetList();
            return View(values);
        
        }
    }
}
