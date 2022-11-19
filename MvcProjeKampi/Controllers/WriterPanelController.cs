using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer1.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel

        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        CategoryManager cm = new CategoryManager(new EFCategoryDal());

        public ActionResult WriterProfile()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult MyHeading()
        {
           
            var values = hm.GetListByWriter();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();

            return View();
        }


        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = 2;
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
            return View();
        }
    }
}