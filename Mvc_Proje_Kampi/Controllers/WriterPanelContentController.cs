using BussinessLayer.Concrate;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
	public class WriterPanelContentController : Controller
	{
		// GET: WriterPanelContent
		ContentManager cm = new ContentManager(new EfContentDal());
		Context c = new Context();
		public ActionResult MyContent(string p )
		{

			p = (string)Session["WriterMail"];
			var writeridinfo=c.Writers.Where(x=>x.WriterMail == p).Select(y=>y.WriterId).FirstOrDefault();
			var contentvalue = cm.GetListByWriter(writeridinfo);
			return View(contentvalue);
		}



		[HttpGet]
		public ActionResult AddContent(int id)
		{
			ViewBag.d = id;
			return View();
		}


		[HttpPost]
		public ActionResult AddContent(Content p)
		{
			string mail = (string)Session["WriterMail"];
			var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterId).FirstOrDefault();

			p.ContentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			p.WriterId = writeridinfo;
			p.ContentStatus = true;
			cm.ContentAdd(p);
			return RedirectToAction("MyContent");
		}


		public ActionResult ToDoList()
		{
			return View();
		}
	}
}