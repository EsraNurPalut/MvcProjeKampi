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

        ContentManager cm = new ContentManager(new EfContentDal());

        [AllowAnonymous]
        public PartialViewResult Index(int id=0)
        {
            var contentlist = cm.GetListByHeadingID(id);
            return PartialView(contentlist);
        }


        [AllowAnonymous]
        public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
    }
}