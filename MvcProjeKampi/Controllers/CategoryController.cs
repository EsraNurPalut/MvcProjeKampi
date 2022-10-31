using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer1.Concrete;
using BusinessLayer1.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concrete;
using FluentValidation.Results;

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
            CategoryValidator categoryValidator = new CategoryValidator(); //validator ürettik,
            ValidationResult results = categoryValidator.Validate(p);
            //result isminde bir tane degişken olusturduk bu değişkenin türü
            // ValidationResult categoryvali sınıfında(p) olan değerlere göre validasyon yap.
            if (results.IsValid)
            {
                cm.CategoryAdd(p); 
                return RedirectToAction("GetCategoryList"); //eger dogruysa getcatlis. yönlendir.

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }

            return View();
        }
    }
}