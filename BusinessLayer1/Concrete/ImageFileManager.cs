using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer1.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer1;
using EntityLayer1.Concrete;

namespace BusinessLayer1.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imagefileDal;

        public ImageFileManager(IImageFileDal imagefileDal)
        {
            _imagefileDal = imagefileDal;
        }

        public List<İmageFile> GetList()
        {
            return _imagefileDal.List();
        }

        //List<İmageFile> IImageFileService.GetList()
        //{
        //    return _imagefileDal.List();
        //}
    }
}
