using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class TopicoAtribuidoController : Controller
	{
		private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;
		private readonly IProjetoAppService _projetoAppService;
		private readonly IAreaAppService _areaAppService;
		private readonly IMestreAppService _mestreAppService;
		private readonly IDisciplinaAppService _disciplinaAppService;

		public TopicoAtribuidoController(ITopicoAtribuidoAppService topicoAtribuidoAppService, IProjetoAppService projetoAppService, IAreaAppService areaAppService, IMestreAppService mestreAppService, IDisciplinaAppService disciplinaAppService)
		{
			_topicoAtribuidoAppService = topicoAtribuidoAppService;
			_projetoAppService = projetoAppService;
			_areaAppService = areaAppService;
			_mestreAppService = mestreAppService;
			_disciplinaAppService = disciplinaAppService;
		}

		public ActionResult Index()
		{
			return View(_topicoAtribuidoAppService.GetAll());
		}

		public ActionResult Details(Guid id)
		{
			var topico = _topicoAtribuidoAppService.GetById(id);
			return topico == null ? (ActionResult)HttpNotFound() : View(topico);
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(TopicoAtribuidoViewModel topicoAtribuidoViewModel)
		{
			if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
			_topicoAtribuidoAppService.Add(topicoAtribuidoViewModel);
			return RedirectToAction("Index");
		}

		public ActionResult Edit(Guid id)
		{
			var topico = _topicoAtribuidoAppService.GetById(id);
			return View(topico);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(TopicoAtribuidoViewModel topicoAtribuidoViewModel)
		{
			if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
			_topicoAtribuidoAppService.Update(topicoAtribuidoViewModel);
			return RedirectToAction("Index");
		}

		public ActionResult Delete(Guid id)
		{
			return View(_topicoAtribuidoAppService.GetById(id));
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			_topicoAtribuidoAppService.Remove(id);
			return RedirectToAction("Index");
		}
		
		public ActionResult Search()
		{
			ViewBag.Projeto_ProjetoId = new SelectList(_projetoAppService.GetAll(), "ProjetoId", "NomeProjeto", "Selecione");
			ViewBag.Area_AreaId = new SelectList(_areaAppService.GetAll(), "AreaId", "Descricao", "Selecione");
			ViewBag.Mestre_MestreId = new SelectList(_mestreAppService.GetAll(), "MestreId", "Nome", "Selecione");
			ViewBag.Disciplina_DisciplinaId = new SelectList(_disciplinaAppService.GetAll(), "DisciplinaId", "Descricao", "Selecione");
			ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
			return View();
		}

		[HttpPost]
		public ActionResult Search(TopicoAtribuidoViewModel topicoAtribuidoViewModel)
		{
			ViewBag.Projeto_ProjetoId = new SelectList(_projetoAppService.GetAll(), "ProjetoId", "NomeProjeto", "Selecione");
			ViewBag.Area_AreaId = new SelectList(_areaAppService.GetAll(), "AreaId", "Descricao", "Selecione");
			ViewBag.Mestre_MestreId = new SelectList(_mestreAppService.GetAll(), "MestreId", "Nome", "Selecione");
			ViewBag.Disciplina_DisciplinaId = new SelectList(_disciplinaAppService.GetAll(), "DisciplinaId", "Descricao", "Selecione");
			ViewBag.Nivel = new SelectList(new ListaNiveis().Niveis(), "Key", "Value", "Selecione");
			return View(_topicoAtribuidoAppService.ResultadoPesquisaDisciplina(topicoAtribuidoViewModel));
		}
	}
}
