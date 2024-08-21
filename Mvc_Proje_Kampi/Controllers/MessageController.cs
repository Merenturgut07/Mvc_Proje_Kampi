using BussinessLayer.Concrate;
using BussinessLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager ms = new MessageManager(new EfMessageDal());

        MessageValidator messageValidator = new MessageValidator();
        public ActionResult Inbox(string p)
        {
            var messagelist = ms.GetMessageListInbox(p);
            return View(messagelist);
        }

        public ActionResult Sendbox(string p)
        {
            var messagelist = ms.GetMessageListSentbox(p);
            return View(messagelist);
        }

        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = ms.GetById(id);
            return View(values);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = ms.GetById(id);
            return View(values);
        }


        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            ValidationResult result = messageValidator.Validate(p);
            if (result.IsValid)
            {
                p.MessageDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                ms.MessageAdd(p);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(p);
        }
    }
}

/*	  <customErrors mode="On">
		  <error statusCode="404" redirect="/ErrorPage/Page404/" />
	  </customErrors>*/