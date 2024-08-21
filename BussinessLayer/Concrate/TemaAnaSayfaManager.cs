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
	public class TemaAnaSayfaManager : ITemaAnaSayfaService
	{
		ITemaAnaSayfaDal _temaAnaSayfaDal;

		public TemaAnaSayfaManager(ITemaAnaSayfaDal temaAnaSayfaDal)
		{
			_temaAnaSayfaDal = temaAnaSayfaDal;
		}

		public TemaAnaSayfa GetById(int id)
		{
			return _temaAnaSayfaDal.Get(x => x.TemaAnaSayfaId == id);
		}

		public List<TemaAnaSayfa> GetList()
		{
			return _temaAnaSayfaDal.List();
		}

		public List<TemaAnaSayfa> GetListByTemaAnaSayfaId(int id)
		{
			throw new NotImplementedException();
		}

		public void TemaAnaSayfaAdd(TemaAnaSayfa temaAnaSayfa)
		{
			_temaAnaSayfaDal.Insert(temaAnaSayfa);
		}

		public void TemaAnaSayfaDelete(TemaAnaSayfa temaAnaSayfa)
		{
			_temaAnaSayfaDal.Delete(temaAnaSayfa);
		}

		public void TemaAnaSayfaUpdate(TemaAnaSayfa temaAnaSayfa)
		{
			_temaAnaSayfaDal.Update(temaAnaSayfa);
		}
	}
}
