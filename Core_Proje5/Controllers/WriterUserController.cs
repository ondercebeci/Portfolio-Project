using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Controllers
{
    public class WriterUserController : Controller
    {
        IWriterUserMenager userMenager = new IWriterUserMenager(new EfWriterUserDal());
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(userMenager.TGetList());
            return Json(values);
        }
        public IActionResult AddUser(WriterUser p)
        {
            userMenager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

    }

}
