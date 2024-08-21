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
	public class CategoryController : Controller
	{
		// GET: Category
		CategoryManager cm = new CategoryManager(new EfCategoryDal());


		public ActionResult Index()
		{
			return View();
		}

		public ActionResult GetCategoryList()
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
			CategoryValidator categoryValidator=new CategoryValidator();
			ValidationResult results = categoryValidator.Validate(p);
			if(results.IsValid)
			{
				cm.CategoryAdd(p);
				return RedirectToAction("GetCategoryList");
			}

			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View(); 
		}
	}
}