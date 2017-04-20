using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class DisciplinaController : Controller
	{

		private readonly IDisciplinaAppService _disciplinaAppService;
		private readonly IAreaAppService _areaAppService;

		public DisciplinaController(IDisciplinaAppService disciplinaAppService, IAreaAppService areaAppService)
		{
			_disciplinaAppService = disciplinaAppService;
			_areaAppService = areaAppService;
		}

		public ActionResult Index()
		{
			var disciplinaViewModel =
				Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(_disciplinaAppService.GetAll());
			ViewBag.ListaDisciplinas =
			Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaAppService.GetAll());
			return View(disciplinaViewModel);
		}

		public ActionResult Details(int id)
		{
			var disciplina = _disciplinaAppService.GetById(id);
			var disciplinaViewModel = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplina);
			if (disciplinaViewModel == null)
			{
				return HttpNotFound();
			}
			return View(disciplinaViewModel);
		}

		public ActionResult Create()
		{
			var areaViewModel =
				Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaAppService.GetAll());
			ViewBag.AreaId = new SelectList(areaViewModel, "AreaId", "Descricao");
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(DisciplinaViewModel disciplinaViewModel)
		{
			if (ModelState.IsValid)
			{
				var dsiciplina = Mapper.Map<DisciplinaViewModel, Disciplina>(disciplinaViewModel);
				_disciplinaAppService.Add(dsiciplina);

				return RedirectToAction("Index");
			}

			var areaViewModel =
				Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaAppService.GetAll());
			ViewBag.AreaId = new SelectList(areaViewModel, "AreaId", "Descricao", disciplinaViewModel.AreaId);

			return View(disciplinaViewModel);
		}

		public ActionResult Edit(int id)
		{
			var disciplina = _disciplinaAppService.GetById(id);
			var disciplinaViewModel = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplina);
			return View(disciplinaViewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(DisciplinaViewModel disciplinaViewModel)
		{
			if (!ModelState.IsValid) return View(disciplinaViewModel);
			var discipliinaDomain = Mapper.Map<DisciplinaViewModel, Disciplina>(disciplinaViewModel);
			_disciplinaAppService.Update(discipliinaDomain);

			var areaViewModel =
					Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaAppService.GetAll());

			ViewBag.AreaId = new SelectList(areaViewModel, "AreaId", "Descricao", disciplinaViewModel.AreaId);
			return View(disciplinaViewModel);
		}

		public ActionResult Delete(int id)
		{
			var disciplina = _disciplinaAppService.GetById(id);
			var disciplinaViewModel = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplina);
			return View(disciplinaViewModel);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			var disciplina = _disciplinaAppService.GetById(id);
			_disciplinaAppService.Remove(disciplina);

			return RedirectToAction("Index");
		}

		[HttpPost]
		public ActionResult Search(Disciplina form)
		{
			ViewBag.ListaDisciplinas = Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaAppService.GetAll());
			var iNscrBqTopico = Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(_disciplinaAppService.ResultadoPesquisaDisciplina(form)); 
			
			return View(iNscrBqTopico);
		}
	}
}
