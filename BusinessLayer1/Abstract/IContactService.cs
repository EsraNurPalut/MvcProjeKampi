using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;

namespace BusinessLayer1.Abstract
{
   public interface IContactService
    {
        List<Contact> GetList();
        void ContactAdd(Contact contact); //ekle
        Contact GetByID(int id);
        void ContactDelete(Contact contact);
        void ContactUpdate(Contact contact);

    }
}
