using BussinessLayer.Concrate;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using BussinessLayer.ValidationRules;
using FluentValidation.Results;

namespace Mvc_Proje_Kampi.Controllers
{
	public class WriterPanelController : Controller
	{
		// GET: WriterPanel
		HeadingManager hm = new HeadingManager(new EfHeadingDal());
		CategoryManager cm = new CategoryManager(new EfCategoryDal());
		WriterManager wm=new WriterManager(new EfWriterDal());
		Context c = new Context();

		[HttpGet]
		public ActionResult WriterProfile(int id=0)
		{
			string p = (string)Session["WriterMail"];
			id = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterId).FirstOrDefault();
			var writervalue=wm.GetById(id);
			return View(writervalue);
		}


		[HttpPost]
		public ActionResult WriterProfile(Writer p)
		{
			WriterValidator writervalidator= new WriterValidator();
			ValidationResult result = writervalidator.Validate(p);

			if (result.IsValid)
			{
				wm.WriterUpdate(p);
				return RedirectToAction("AllHeading","WriterPanel");
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



		public ActionResult MyHeading(string p)
		{

			p = (string)Session["WriterMail"];
			var writeridainfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterId).FirstOrDefault();

			var values = hm.GetListByWriter(writeridainfo);
			return View(values);
		}

		[HttpGet]
		public ActionResult NewHeading()
		{

			List<SelectListItem> valuecategory = (from x in cm.GetCategoryList()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryId.ToString()
												  }).ToList();
			ViewBag.vlc = valuecategory;

			return View();
		}

		[HttpPost]
		public ActionResult NewHeading(Heading p)
		{
			string writermailinfo = (string)Session["WriterMail"];
			var writeridainfo = c.Writers.Where(x => x.WriterMail == writermailinfo).Select(y => y.WriterId).FirstOrDefault();
			p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.WriterId = writeridainfo;
			p.HeadingStatus = true;
			hm.HeadingAdd(p);
			return RedirectToAction("MyHeading");
		}




		[HttpGet]
		public ActionResult EditHeading(int id)
		{
			List<SelectListItem> valuecategory = (from x in cm.GetCategoryList()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryId.ToString()
												  }).ToList();

			ViewBag.vlc = valuecategory;
			var HeadingValue = hm.GetById(id);
			return View(HeadingValue);
		}

		[HttpPost]

		public ActionResult EditHeading(Heading p)
		{
			hm.HeadingUpdate(p);
			return RedirectToAction("MyHeading");
		}


		public ActionResult DeleteHeading(int id)
		{
			var HeadingValue = hm.GetById(id);
			HeadingValue.HeadingStatus = false;
			hm.HeadingDelete(HeadingValue);
			return RedirectToAction("MyHeading");
		}



		public ActionResult AllHeading()
		{
			var heading = hm.GetList().ToPagedList(1, 4);
			return View(heading);
		}
	}
}

