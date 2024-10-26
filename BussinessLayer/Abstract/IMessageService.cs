using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetMessageListInbox(string p);

        List<Message> GetMessageListSentbox(string p);
  //      List<Message> GetMessageListInbox();
		//List<Message> GetMessageListSentbox();

        void MessageAdd(Message message);
        Message GetById(int id);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);
    }
}
