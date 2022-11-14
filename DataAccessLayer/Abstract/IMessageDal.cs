using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal: IRepository<Message>
    {
    }
}
