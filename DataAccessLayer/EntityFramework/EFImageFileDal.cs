using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer1;

namespace DataAccessLayer.EntityFramework
{
    class EFImageFileDal:GenericRepository<İmageFile>,IImageFileDal
    {
    }
}
