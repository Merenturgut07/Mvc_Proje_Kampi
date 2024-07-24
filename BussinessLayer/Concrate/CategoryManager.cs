﻿using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
	public class CategoryManager
	{
		GenericRepository<Category> repo = new GenericRepository<Category>();

		public List<Category> GetAllBl()
		{
			return repo.List();
		}

		public void CategoryAddBl(Category p)
		{
			if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription==""|| p.CategoryName.Length >= 51)
			{
				//Hata Mesajı
			}
			else
			{
				repo.Insert(p);
			}
		}

	}
}