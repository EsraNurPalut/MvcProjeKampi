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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _HeadingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _HeadingDal = headingDal;
        } //constr metodu

        public Heading GetByID(int id)
        {
            return _HeadingDal.Get(x => x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
            return _HeadingDal.List();
        }

        public void HeadingAdd(Heading heading)
        {
            _HeadingDal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            _HeadingDal.Delete(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _HeadingDal.Update(heading);
        }
    }
}
