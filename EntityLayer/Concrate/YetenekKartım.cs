using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class YetenekKartım
	{
		[Key]
		public int YKId { get; set; }


		[StringLength(25)]
		public string YKTitle { get; set; }

		[StringLength(500)]
		public string YKImageUrl { get; set; }

		[StringLength(500)]
		public string YKDescription { get; set; }

		[StringLength(50)]
		public string YKIsim { get; set; }



		[StringLength(25)]
		public string YKYetenekBaslik1 { get; set; }


		[StringLength(25)]
		public string YKYetenekBaslik2 { get; set; }


		[StringLength(25)]
		public string YKYetenekBaslik3 { get; set; }

		[StringLength(25)]
		public string YKYetenekBaslik4 { get; set; }


		[StringLength(50)]
		public string YKDeger1 { get; set; }

		[StringLength(50)]
		public string YKDeger2 { get; set; }

		[StringLength(50)]
		public string YKDeger3 { get; set; }

		[StringLength(50)]
		public string YKDeger4 { get; set; }
	}
}
