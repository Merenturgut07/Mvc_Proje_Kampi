using Mvc_Proje_Kampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
	public class ChartController : Controller
	{
		// GET: Chart
		public ActionResult Index()
		{
			return View();
		}




		[HttpPost]
		public ActionResult CategoryChart()
		{
			return Json(BlogList(), JsonRequestBehavior.AllowGet);
		}

		public List<CategoryClass> BlogList()
		{
			List<CategoryClass> ct = new List<CategoryClass>();
			ct.Add(new CategoryClass()
			{
				CategoryName = "Yazılım",
				CategoryCount = 8
			});
			ct.Add(new CategoryClass()
			{
				CategoryName = "Spor",
				CategoryCount = 7
			});
			ct.Add(new CategoryClass()
			{
				CategoryName = "Teknoloji",
				CategoryCount = 6
			});
			ct.Add(new CategoryClass()
			{
				CategoryName = "Asp.Net",
				CategoryCount = 7
			});

			return ct;
		}





	}
}