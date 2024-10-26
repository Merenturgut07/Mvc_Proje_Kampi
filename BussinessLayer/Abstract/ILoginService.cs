using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
	public interface ILoginService
	{
		List<Admin> GetList();
		void AdminAdd(Admin admin);
		void AdminDelete(Admin admin);
		void AdminUpdate(Admin admin);
		Admin GetById(int id);
	}
}
