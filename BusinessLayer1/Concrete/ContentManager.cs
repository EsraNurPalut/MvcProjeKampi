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
    public class ContentManager : IContentService
    {

        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal) //YAPICI metot
        {
            _contentDal = contentDal;
        }

        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingID (int id)
        {
            return _contentDal.List(x => x.HeadingID == id); //dısarıdan girdiğim id ye göre listeleme yapacak
        }

        public List<Content> GetListByWriter(int id)
        {
            return _contentDal.List(x => x.WriterID == id);
        }
    }
}
