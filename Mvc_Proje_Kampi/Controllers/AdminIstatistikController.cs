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
    public class AdminIstatistikController : Controller
    {
		Context c=new Context();
		public ActionResult Index()
        {
			var deger1 = c.Writers.Count().ToString();
			ViewBag.d1 = deger1;
			var deger2 = c.Admins.Count().ToString();
			ViewBag.d2 = deger2;
			var deger3 = c.Categories.Count().ToString();
			ViewBag.d3 = deger3;
			var deger4 = c.Headings.Count().ToString();
			ViewBag.d4 = deger4;
			var deger5 = c.Headings.Count(x => x.HeadingName == "İtiraflarım ").ToString();
			ViewBag.d5 = deger5;
			var deger6= c.Headings.Where(x => x.CategoryId == 4).Count();
			ViewBag.d6 = deger6;
			var deger7 = c.Admins.Where(x => x.AdminRole == "A").Count();
			ViewBag.d7 = deger7;
			var deger8 = c.Contents.Count().ToString();
			ViewBag.d8 = deger8;
			return View();
		}
    }
}