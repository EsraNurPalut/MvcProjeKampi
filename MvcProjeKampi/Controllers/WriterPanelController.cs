using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer1.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel

        HeadingManager hm = new HeadingManager(new EFHeadingDal());

        public ActionResult WriterProfile()
        {
            return View();
        }

        public ActionResult MyHeading(int id)
        {
            id = 2;
            var values = hm.GetListByWriter(id);
            return View();
        }
    }
}