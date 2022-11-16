using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer1.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer1.Concrete;

namespace BusinessLayer1.Concrete
{
    public class ContactManager : IContactService
    {

        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        //public ContactManager(IContactDal contactDal)
        //{
        //    this.contactDal = contactDal;
        //}

        public void ContactAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public Contact GetByID(int id)
        {
            return _contactDal.Get(x=>x.ContactID==id);

        }

        public List<Contact> GetList()
        {
            return _contactDal.List();

        }
    }
}
