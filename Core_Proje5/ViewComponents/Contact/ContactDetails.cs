using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactMenager contactMenager = new ContactMenager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactMenager.TGetList();
            return View(values);
        }
    }
}
