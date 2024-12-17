using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageMenager messageMenager = new MessageMenager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {  
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messageMenager.TAdd(p);
        //    return View();
        //}
    }
}
