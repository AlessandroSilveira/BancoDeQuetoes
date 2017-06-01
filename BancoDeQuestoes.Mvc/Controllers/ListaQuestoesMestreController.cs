using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class ListaQuestoesMestreController : Controller
    {
        private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;

        public ListaQuestoesMestreController(ITopicoAtribuidoAppService topicoAtribuidoAppService)
        {
            _topicoAtribuidoAppService = topicoAtribuidoAppService;
        }

        // GET: ListaQuestoesMestre
        public ActionResult Index()
        {
            Guid mestreId = new Guid("d6eada77-a031-e711-a5d7-7429afa32c0c");

            var listaQuestoesMestre = _topicoAtribuidoAppService.Search(a => a.MestreId.Equals(mestreId));

            return View(listaQuestoesMestre);
        }
    }
}