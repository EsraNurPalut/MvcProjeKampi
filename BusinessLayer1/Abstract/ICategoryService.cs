using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;

namespace BusinessLayer1.Abstract
{
   public  interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAdd(Category category);
    }
}
