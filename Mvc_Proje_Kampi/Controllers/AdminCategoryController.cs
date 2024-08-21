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
	public class AdminCategoryController : Controller
	{
		CategoryManager cm = new CategoryManager(new EfCategoryDal());

		//[Authorize(Roles ="B")]
		public ActionResult Index()
		{
			var categoryvalues = cm.GetCategoryList();
			return View(categoryvalues);
		}


		[HttpGet]
		public ActionResult AddCategory()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddCategory(Category p)
		{
			CategoryValidator categoryValidator = new CategoryValidator();
			ValidationResult result = categoryValidator.Validate(p);
			if (result.IsValid)
			{
				cm.CategoryAdd(p);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}

		public ActionResult DeleteCategory(int id)
		{
			var categoryvalue = cm.GetById(id);
			cm.CategoryDelete(categoryvalue);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult UpdateCategory(int id)
		{
			var kategoryvalue=cm.GetById(id);
			return View(kategoryvalue);
		}


		[HttpPost]
		public ActionResult UpdateCategory(Category p)
		{
			cm.CategoryUpdate(p);
			return RedirectToAction("Index");
		}
	}
}