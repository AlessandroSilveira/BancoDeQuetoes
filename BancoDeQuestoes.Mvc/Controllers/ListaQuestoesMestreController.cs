using System;
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

        public ActionResult Index()
        {
            Guid id = new Guid("d6eada77-a031-e711-a5d7-7429afa32c0c");
            var listaQuestoesMestreViewModel = _topicoAtribuidoAppService.Search(a => a.MestreId.Equals(id));
            return View(listaQuestoesMestreViewModel);
        }
    }
}