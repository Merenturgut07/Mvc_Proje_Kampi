using BussinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager ad = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues=ad.GetList();
            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

		[HttpPost]
		public ActionResult AddAdmin(Admin p)
		{
            ad.AdminAdd(p);
            return RedirectToAction("Index");
		}


		[HttpGet]
		public ActionResult UpdateAdmin(int id)
		{
			var adminvalue = ad.GetById(id);
			return View(adminvalue);
		}


		[HttpPost]
		public ActionResult UpdateAdmin(Admin p)
		{
			ad.AdminUpdate(p);
			return RedirectToAction("Index");
		}
	}
}