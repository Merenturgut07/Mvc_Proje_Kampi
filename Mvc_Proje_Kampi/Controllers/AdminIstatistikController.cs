using BussinessLayer.Concrate;
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
		// GET: AdminIstatistik
		public ActionResult Index()
        {
			//ViewBag.categoryCount = cm
			return View();
        }
    }
}