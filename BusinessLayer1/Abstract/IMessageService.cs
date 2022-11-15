using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1.Concrete;

namespace BusinessLayer1.Abstract
{
   public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();

        void MessageAdd(Message message); //ekle
        Message GetByID(int id);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);
    }
}
