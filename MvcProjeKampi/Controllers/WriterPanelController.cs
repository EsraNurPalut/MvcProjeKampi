using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer1.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concrete;
using PagedList;
using PagedList.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel

        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        Context c = new Context();
   

        public ActionResult WriterProfile()
        {
            return View();
        }

        public ActionResult MyHeading( string p)
        {
            
            p = (string)Session["WriterMail"];
             var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
           
            var values = hm.GetListByWriter(writeridinfo);
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
            ViewBag.vlc = valuecategory;
            return View();
        }


        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            string writermailinfo = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == writermailinfo).Select(y => y.WriterID).FirstOrDefault();
           
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = writeridinfo;
            p.HeadingStatus = true;
            hm.HeadingAdd(p);
            return RedirectToAction("MyHeading");
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
            return RedirectToAction("MyHeading");
        }

        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = hm.GetByID(id);
            HeadingValue.HeadingStatus = false;
            hm.HeadingDelete(HeadingValue);
            return RedirectToAction("MyHeading");

        }
        [AllowAnonymous]
        public ActionResult AllHeading()
        {
            var headings = hm.GetList().ToPagedList(1,4); //her sayfada kac tane veri olacagını yazdık.
            return View(headings);
        }

    }
}


//<customErrors mode="On">
         // < error statusCode = "404" redirect = "/ErorPage/Page404/" />
   
         //</ customErrors >