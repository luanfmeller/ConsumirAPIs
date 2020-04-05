using System;
using System.Web.Mvc;
using Correios.CEP;

namespace ConsumirAPIs.Controllers
{
    public class CorreiosCEPController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult BuscarEnderecoApi(string cep)
        {
            try {
                return Json(new
                {
                    success = true,
                    data = correiosCEP.GetAddress(cep),
                }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new
                {
                    success = false,
                    data = ex.Message
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}