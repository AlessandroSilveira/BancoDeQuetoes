using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class DisciplinaController : Controller
	{
		public DisciplinaController(IDisciplinaAppService disciplinaRepository, IAreaAppService areaRepository)
		{
			DisciplinaRepository = disciplinaRepository;
			AreaRepository = areaRepository;
		}


		private   IDisciplinaAppService DisciplinaRepository { get; set; }
		private   IAreaAppService AreaRepository { get;  }

		public ActionResult Index()
		{
			var disciplinaViewModel =
				Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(DisciplinaRepository.GetAll());
			ViewBag.ListaDisciplinas =
			Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(AreaRepository.GetAll());
			return View(disciplinaViewModel);
		}

		public ActionResult Details(int id)
		{
			var disciplina = DisciplinaRepository.GetById(id);
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
				Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(AreaRepository.GetAll());
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
				DisciplinaRepository.Add(dsiciplina);

				return RedirectToAction("Index");
			}

			var areaViewModel =
				Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(AreaRepository.GetAll());
			ViewBag.AreaId = new SelectList(areaViewModel, "AreaId", "Descricao", disciplinaViewModel.AreaId);

			return View(disciplinaViewModel);
		}

		public ActionResult Edit(int id)
		{
			var disciplina = DisciplinaRepository.GetById(id);
			var disciplinaViewModel = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplina);
			return View(disciplinaViewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(DisciplinaViewModel disciplinaViewModel)
		{
			if (!ModelState.IsValid) return View(disciplinaViewModel);
			var discipliinaDomain = Mapper.Map<DisciplinaViewModel, Disciplina>(disciplinaViewModel);
			DisciplinaRepository.Update(discipliinaDomain);

			var areaViewModel =
					Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(AreaRepository.GetAll());

			ViewBag.AreaId = new SelectList(areaViewModel, "AreaId", "Descricao", disciplinaViewModel.AreaId);
			return View(disciplinaViewModel);
		}

		public ActionResult Delete(int id)
		{
			var disciplina = DisciplinaRepository.GetById(id);
			var disciplinaViewModel = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplina);
			return View(disciplinaViewModel);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			var disciplina = DisciplinaRepository.GetById(id);
			DisciplinaRepository.Remove(disciplina);

			return RedirectToAction("Index");
		}

		[HttpPost]
		public ActionResult Search(Disciplina form)
		{
			ViewBag.ListaDisciplinas = Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(AreaRepository.GetAll());
			var iNscrBqTopico = Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(DisciplinaRepository.ResultadoPesquisaDisciplina(form)); 
			
			return View(iNscrBqTopico);
		}
	}
}
