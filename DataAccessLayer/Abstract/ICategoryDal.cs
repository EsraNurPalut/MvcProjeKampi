using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDal
    {
        //CRUD
        //Typer Name();--- Metot tanımlarken

        List<Category> List(); //listeleme

        void Insert(Category p);  //ekleme işlemi

        void Update(Category p);  //güncelleme

        void Delete(Category p); //silme 

    }
}
