﻿using BusinessLayer.Concrate;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/message")]
    public class MessageController : Controller
    {
        WriterMessageMenager writerMessageMenager = new WriterMessageMenager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageMenager.GetListReceiverMessage(p);
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageMenager.GetListSenderMessage(p);
            return View(messageList);
        }
       [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageMenager.GetByID(id);
            return View(writerMessage);
        }
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageMenager.GetByID(id);
            return View(writerMessage);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writerMessageMenager.TAdd(p); 
            return RedirectToAction("SenderMessage");
        }
    }
}
