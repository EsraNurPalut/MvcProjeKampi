using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer1.Concrete;
using BusinessLayer1.ValidatiorRules;
using DataAccessLayer.EntityFramework;
using EntityLayer1.Concrete;
using FluentValidation.Results;

namespace MvcProjeKampi.Controllers
{
    public class WriterController : Controller
    {

        WriterManager wm = new WriterManager(new EFWriterDal());
        // GET: Writer
        public ActionResult Index()
        {
            var WriterValues = wm.GetList();
            return View(WriterValues);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
            WriterValidator writervalidation = new WriterValidator();
            ValidationResult result = writervalidation.Validate(p);
            if (result.IsValid)  //sonuclar dogru ise
            {
                wm.WriterAdd(p);
                return RedirectToAction("Index");
            }
            else 
            {
                foreach (var item in result.Errors) 
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}