﻿using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Areas.Writer.ViewComponents
{
    public class Notification: ViewComponent
    {
        AnnouncementMenager announcementMenager = new AnnouncementMenager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcementMenager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
