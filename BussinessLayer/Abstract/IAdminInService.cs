using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
	public interface IAdminInService
	{
		List<Admin> GetList();
		void AdminAdd(Admin admin);
		Admin GetById(int id);
		void AdminDelete(Admin admin);
		void AdminUpdate(Admin admin);
	}
}
