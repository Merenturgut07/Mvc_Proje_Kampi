using BussinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
    public class MessageManager : IMessageService
    {

        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);
        }

        //public List<Message> GetMessageListInbox()
        //{
        //    return _messageDal.List(x => x.ReciverMail == "admin2@gmail.com");
        //}


        //public List<Message> GetMessageListSentbox()
        //{
        //    return _messageDal.List(x => x.SenderMail == "admin2@gmail.com");
        //}


        public List<Message> GetMessageListInbox(string p)
        {
            return _messageDal.List(x => x.ReciverMail == p);
        }



        public List<Message> GetMessageListSentbox(string p)
        {
            return _messageDal.List(x => x.SenderMail == p);
        }

		public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
