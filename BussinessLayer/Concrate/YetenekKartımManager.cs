using BussinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
	public class YetenekKartımManager : IYetenekKartımService
	{

		IYetenekKartımDal _yetenekKartımDal;

		public YetenekKartımManager(IYetenekKartımDal yetenekKartımDal)
		{
			_yetenekKartımDal = yetenekKartımDal;
		}

		public List<YetenekKartım> GetList()
		{
			return _yetenekKartımDal.List();
		}

	}
}
