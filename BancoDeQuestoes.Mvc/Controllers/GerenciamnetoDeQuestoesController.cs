using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class GerenciamnetoDeQuestoesController : Controller
    {
	    private IQuestaoAppService _questaoAppService;

	    public GerenciamnetoDeQuestoesController(IQuestaoAppService questaoAppService)
	    {
			_questaoAppService = questaoAppService;
	    }

	    // GET: GerenciamnetoDeQuestoes
        public ActionResult Index()
        {
			var lista = Mapper.Map<IEnumerable<Questao>,IEnumerable<GerenciamnetoDeQuestoesController>>(_questaoAppService.GetListaGerenciamento());
            return View(lista);
        }
    }
}