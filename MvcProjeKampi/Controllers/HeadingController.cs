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
    public class HeadingController : Controller
    {
       
        HeadingManager hm = new HeadingManager(new EFHeadingDal());

        CategoryManager cm = new CategoryManager(new EFCategoryDal());

        WriterManager wm = new WriterManager(new EFWriterDal());

        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();

            List<SelectListItem> valuewriter = (from x in wm.GetList()
                                                select new SelectListItem {
                                                    Text = x.WriterName + " " + x.WriterSurName,
                                                    Value = x.WriterID.ToString()
                                                }).ToList();
            ViewBag.vlc = valuecategory; //vlc : sondaki c category için yazılmış bir c harfi
            ViewBag.vlw = valuewriter; //vlw: sondaki w writer için yazılmış bir w harfi
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult EditHeading(int id) //düzenle kısmının web sayfası 
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList(); // categoryıd değişebilir.
            ViewBag.vlc = valuecategory; //vlc : sondaki c category için yazılmış bir c harfi

            var HeadingValue = hm.GetByID(id); //baslık değeri id göre getir

            return View(HeadingValue);
        }
        [HttpPost] //güncelle butonuna bastıgında calışacak.
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = hm.GetByID(id);
            HeadingValue.HeadingStatus = false;
            hm.HeadingDelete(HeadingValue);
            return RedirectToAction("Index");

        }







        }
}