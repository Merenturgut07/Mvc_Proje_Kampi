using BussinessLayer.Concrate;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
	public class ContentController : Controller
	{
		// GET: Contrent
		ContentManager cm = new ContentManager(new EfContentDal());
		public ActionResult Index()
		{
			return View();
		}


		public ActionResult GetAllContent(string p)
		{
			var values = cm.GetList(p);
			if (p == null)
			{
				return View(cm.GetList(""));
			}
			//var values=c.Contents.ToList();
			return View(values);
		}



		public ActionResult ContentByHeading(int id)
		{
			var contentvalue = cm.GetListByHeadingId(id);
			return View(contentvalue);
		}
	}
}