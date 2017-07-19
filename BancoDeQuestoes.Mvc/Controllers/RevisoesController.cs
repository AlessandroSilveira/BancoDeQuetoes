using System;
using System.Linq;
using BancoDeQuestoes.Application.Interface.Repositories;
using System.Web.Mvc;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class RevisoesController : Controller
    {

	    private readonly IQuestaoAppService _questaoAppService;
	    private readonly IRevisorAppService _revisorAppService;

	    public RevisoesController(IQuestaoAppService questaoAppService, IRevisorAppService revisorAppService)
	    {
		    _questaoAppService = questaoAppService;
		    _revisorAppService = revisorAppService;
	    }


	    // GET: Revisoes
		[Authorize(Roles = "Admin")]
		public ActionResult Index()
        {

            return View(_questaoAppService.Search(a=>a.Status.Equals("Item Elaborado aguardando ser enviado para Revisão da banca")));
        }


	    public ActionResult AtribuirQuestaoParaRevisao(Guid id)
	    {

		    ViewBag.dadosQuestao = _questaoAppService.GetById(id);
		    ViewBag.ListaRevisores = _revisorAppService.GetAll().ToList();


			return View();

	    }
	}
}