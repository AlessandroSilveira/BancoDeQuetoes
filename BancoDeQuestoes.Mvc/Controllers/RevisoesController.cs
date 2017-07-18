using System;
using BancoDeQuestoes.Application.Interface.Repositories;
using System.Web.Mvc;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class RevisoesController : Controller
    {

	    private readonly IQuestaoAppService _questaoAppService;

	    public RevisoesController(IQuestaoAppService questaoAppService)
	    {
		    _questaoAppService = questaoAppService;
	    }


	    // GET: Revisoes
		[Authorize(Roles = "Admin")]
		public ActionResult Index()
        {

            return View(_questaoAppService.Search(a=>a.Status.Equals("Item Elaborado aguardando ser enviado para Revisão da banca")));
        }


	    public ActionResult AtribuirQuestaoParaRevisao(Guid questaoId)
	    {



		    return View();

	    }
	}
}