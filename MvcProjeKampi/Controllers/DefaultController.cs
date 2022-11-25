using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer1.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjeKampi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
    }
}