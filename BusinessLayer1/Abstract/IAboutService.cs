using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;

namespace BusinessLayer1.Abstract
{
   public interface IAboutService
    {

        List<About> GetList();
        void AboutAdd(About about); //ekle
        About GetByID(int id);
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
