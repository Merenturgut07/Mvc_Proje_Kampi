using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
    public class TemaController : Controller
    {
        // GET: Tema
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult PartialTemaAnaSayfa()
        {
            return PartialView();
        }


		public PartialViewResult PartialTemaGeliştirmeAraclari()
		{
			return PartialView();
		}

		public PartialViewResult PartialTemaHakkımda()
		{
			return PartialView();
		}

		public PartialViewResult PartialTemaGörseller()
		{
			return PartialView();
		}

		public PartialViewResult PartialTemaIletisim()
		{
			return PartialView();
		}
	}
}