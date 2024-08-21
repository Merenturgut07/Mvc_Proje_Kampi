using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
	public interface ITemaAnaSayfaService
	{

		List<TemaAnaSayfa> GetList();
		List<TemaAnaSayfa> GetListByTemaAnaSayfaId(int id);
		void TemaAnaSayfaAdd(TemaAnaSayfa temaAnaSayfa);
		void TemaAnaSayfaDelete(TemaAnaSayfa temaAnaSayfa);
		void TemaAnaSayfaUpdate(TemaAnaSayfa temaAnaSayfa);
		TemaAnaSayfa GetById(int id);

	}
}
