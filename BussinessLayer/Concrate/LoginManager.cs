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
	public class LoginManager:ILoginService
	{
		ILoginDal _loginDal;

		public LoginManager(ILoginDal loginDal)
		{
			_loginDal = loginDal;
		}

		public void AdminAdd(Admin admin)
		{
			throw new NotImplementedException();
		}

		public void AdminDelete(Admin admin)
		{
			throw new NotImplementedException();
		}

		public void AdminUpdate(Admin admin)
		{
			throw new NotImplementedException();
		}

		public Admin GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Admin> GetList()
		{
			throw new NotImplementedException();
		}
	}
}
