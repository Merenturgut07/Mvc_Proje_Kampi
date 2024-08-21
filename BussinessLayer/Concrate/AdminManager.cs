using BussinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
	public class AdminManager : IAdminInService
	{
		IAdminDal _adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public void AdminAdd(Admin admin)
		{
			_adminDal.Insert(admin);
		}

		public void AdminDelete(Admin admin)
		{
			throw new NotImplementedException();
		}

		public void AdminUpdate(Admin admin)
		{
			_adminDal.Update(admin);
		}

		public Admin GetById(int id)
		{
			return _adminDal.Get(x => x.AdminId == id);
		}

		public List<Admin> GetList()
		{
			return _adminDal.List();
		}
	}
}
