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
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EFCategoryDal());


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
           var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
           // cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}