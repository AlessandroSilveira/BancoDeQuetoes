using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;


namespace BancoDeQuestoes.Mvc.Controllers
{
	public class DisciplinaController : Controller
	{
		private readonly IDisciplinaAppService _disciplinaAppService;
		private readonly IAreaAppService _areaAppService;
	    private readonly IProjetoAppService _projetoAppService;
	    private readonly IMestreAppService _mestreAppService;

		public DisciplinaController(IDisciplinaAppService disciplinaAppService, IAreaAppService areaAppService, 
            IProjetoAppService projetoAppService, IMestreAppService mestreAppService)
		{
			_disciplinaAppService = disciplinaAppService;
			_areaAppService = areaAppService;
		    _projetoAppService = projetoAppService;
		    _mestreAppService = mestreAppService;
		}

		public ActionResult Index()
		{
			var disciplinaViewModel = _disciplinaAppService.GetAll();
			ViewBag.ListaDisciplinas = _areaAppService.GetAll();
			ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
			return View(disciplinaViewModel);
		}

		public ActionResult Details(Guid id)
		{
			var disciplina = _disciplinaAppService.GetById(id);
			return disciplina == null ? (ActionResult)HttpNotFound() : View(disciplina);
		}

		public ActionResult Create()
		{
			ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
			ViewBag.Area_AreaId = new SelectList(_areaAppService.GetAll(), "AreaId", "Descricao");
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(DisciplinaViewModel disciplinaViewModel)
		{
			if (ModelState.IsValid)
			{
				_disciplinaAppService.Add(disciplinaViewModel);
				return RedirectToAction("Index");
			}

			var areaViewModel = _areaAppService.GetAll();
			ViewBag.Area_AreaId = new SelectList(areaViewModel, "AreaId", "Descricao");
			ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
		    return RedirectToAction("Index");
        }

		public ActionResult Edit(Guid id)
		{
			var disciplina = _disciplinaAppService.GetById(id);
			ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
			ViewBag.Area_AreaId = new SelectList(_areaAppService.GetAll(), "AreaId", "Descricao");
			return View(disciplina);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(DisciplinaViewModel disciplinaViewModel)
		{
		    if (!ModelState.IsValid)
		    {
		        return View(disciplinaViewModel);
		    }
            
            _disciplinaAppService.Update(disciplinaViewModel);
			ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
		    ViewBag.Area_AreaId = new SelectList(_areaAppService.GetAll(), "AreaId", "Descricao");
            var disciplina = _disciplinaAppService.GetAll();
            return View("Index", disciplina);
		}

		public ActionResult Delete(Guid id)
		{
			var disciplina = _disciplinaAppService.GetById(id);
			return View(disciplina);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			_disciplinaAppService.Remove(id);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public ActionResult Search(DisciplinaViewModel form)
		{
			ViewBag.ListaDisciplinas =_areaAppService.GetAll();
			var iNscrBqTopico =_disciplinaAppService.ResultadoPesquisaDisciplina(form);
			ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
			return View(iNscrBqTopico);
		}


	    public ActionResult Atribuicao()
	    {
	        ViewBag.Projeto_ProjetoId = new SelectList(_projetoAppService.GetAll(), "ProjetoId", "NomeProjeto", "Selecione");
	        ViewBag.Area_AreaId = new SelectList(_areaAppService.GetAll(), "AreaId", "Descricao", "Selecione");
	        ViewBag.Mestre_MestreId = new SelectList(_mestreAppService.GetAll(), "MestreId", "Nome", "Selecione");
	        ViewBag.Disciplina_DisciplinaId = new SelectList(_disciplinaAppService.GetAll(), "DisciplinaId", "Descricao", "Selecione");
	        ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
	        return View();
	    }

	    [HttpPost]
	    public ActionResult Atribuicao(DisciplinaViewModel disciplinaViewModel)
	    {
	        ViewBag.Projeto_ProjetoId = new SelectList(_projetoAppService.GetAll(), "ProjetoId", "NomeProjeto", "Selecione");
	        ViewBag.Area_AreaId = new SelectList(_areaAppService.GetAll(), "AreaId", "Descricao", "Selecione");
	        ViewBag.Mestre_MestreId = new SelectList(_mestreAppService.GetAll(), "MestreId", "Nome", "Selecione");
	        ViewBag.Disciplina_DisciplinaId = new SelectList(_disciplinaAppService.GetAll(), "DisciplinaId", "Descricao", "Selecione");
	        ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
	        return View(_disciplinaAppService.ResultadoPesquisaDisciplinaAtribuicao(disciplinaViewModel));
	    }

    }
}
