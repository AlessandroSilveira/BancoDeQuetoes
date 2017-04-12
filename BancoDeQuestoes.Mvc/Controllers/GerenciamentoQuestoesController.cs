using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class GerenciamentoQuestoesController : Controller
    {
        // GET: GerenciamentoQuestoes
        public ActionResult Index()
        {
            return View();
        }
    }
}