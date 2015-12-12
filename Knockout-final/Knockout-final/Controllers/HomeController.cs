using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout_final.Controllers
{
    public class Model {
        public static List<dynamic> lista = new List<dynamic>() { 
                new { titulo= "Titulo item 1", conteudo= "Conteúdo obtido de GetLIst()" },
		        new { titulo= "Titulo item 2", conteudo= "Conteúdo obtido de GetLIst()" },
		        new { titulo= "Titulo item 3", conteudo= "Conteúdo obtido de GetLIst()" }
            };
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetList() {

            return Json(Model.lista);
        }

        public ActionResult Create(string titulo, string conteudo) {

            Model.lista.Add(new { titulo = titulo, conteudo = conteudo });

            return new HttpStatusCodeResult(200);
        }

    }
}