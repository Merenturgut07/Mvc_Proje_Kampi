using BussinessLayer.Concrate;
using BussinessLayer.ValidationRules;
using DataAccesLayer.Concrete;
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
	public class WriterPanelMessageController : Controller
	{
		// GET: WriterPanelMessage
		MessageManager ms = new MessageManager(new EfMessageDal());
		MessageValidator messageValidator = new MessageValidator();
		public ActionResult Inbox()
		{
			string p = (string)Session["WriterMail"];
			var messagelist = ms.GetMessageListInbox(p);
			return View(messagelist);
		}


		public ActionResult Sendbox()
		{
			string p = (string)Session["WriterMail"];
			var messagelist = ms.GetMessageListSentbox(p);
			return View(messagelist);
		}

		public PartialViewResult WriterMessageListMenu()
		{
			return PartialView();
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
			string sender = (string)Session["WriterMail"];
			ValidationResult result = messageValidator.Validate(p);
			if (result.IsValid)
			{
				p.SenderMail = sender;
				p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
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