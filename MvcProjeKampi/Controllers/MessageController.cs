using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer1.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message

        MessageManager cm = new MessageManager(new EFMessageDal());

        public ActionResult Inbox()
        {
            var messagelist = cm.GetList();
            return View(messagelist);
        }
    }
}