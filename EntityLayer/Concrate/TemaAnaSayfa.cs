using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class TemaAnaSayfa
	{
		[Key]
		public int TemaAnaSayfaId { get; set; }


		[StringLength(50)]
		public string TemaAnaSayfaIsim { get; set; }


		[StringLength(50)]
		public string TemaAnaSayfaAltBaslik { get; set; }



		[StringLength(50)]
		public string TemaAnaSayfaBaslik { get; set; }
	}
}
