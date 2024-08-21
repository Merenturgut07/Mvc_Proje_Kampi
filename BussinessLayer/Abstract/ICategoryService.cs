using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
	public interface ICategoryService
	{
		List<Category> GetCategoryList();
		void CategoryAdd(Category category);
		Category GetById(int id);
		void CategoryDelete(Category category);
		void CategoryUpdate(Category category);
	}
}
