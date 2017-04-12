using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class GerenciamentoQuestoesController : Controller
	{
		private readonly IQuestaoAppService _questaoAppService;

		public GerenciamentoQuestoesController(IQuestaoAppService questaoAppService)
		{
			_questaoAppService = questaoAppService;
		}

		// GET: GerenciamentoQuestoes
        public ActionResult Index()
        {
	        var listaQuestao = Mapper.Map<IEnumerable<Questao>, IEnumerable<QuestaoViewModel>>(_questaoAppService.GetAll());
            return View(listaQuestao);
        }
    }
}