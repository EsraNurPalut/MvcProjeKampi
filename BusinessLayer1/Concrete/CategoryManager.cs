﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer1.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer1.Concrete;

namespace BusinessLayer1.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        // GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL()
        //{

        //    return repo.List();
        //}

        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == " " || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51) 
        //    {
        //        //hata mesajı

        //    }
        //    else {
        //        repo.Insert(p);

        //    }
        //}
        public List<Category> GetList()
        {
            return 
        }
    }
}
