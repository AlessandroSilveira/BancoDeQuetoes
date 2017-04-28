using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class RevisorController : Controller
	{
		private readonly IRevisorAppService _revisorAppService;
		private readonly IAreaAppService _areaAppService;

		public RevisorController(IRevisorAppService revisorAppService, IAreaAppService areaAppService)
		{
			_revisorAppService = revisorAppService;
			_areaAppService = areaAppService;
		}

		public ActionResult Index()
		{
			return View(_revisorAppService.GetAll());
		}

		public ActionResult Details(Guid id)
		{
			var revisor = _revisorAppService.GetById(id);
			return revisor == null ? (ActionResult)HttpNotFound() : View(revisor);
		}

		public ActionResult Create()
		{
			var areaViewModel = _areaAppService.GetAll();
			ViewBag.AreaId = new SelectList(areaViewModel, "AreaId", "Descricao");
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(RevisorViewModel revisorViewModel)
		{
			var areaViewModel = _areaAppService.GetAll();
			if (!ModelState.IsValid)
			{
				ViewBag.AreaId = new SelectList(areaViewModel, "AreaId", "Descricao");
				return View(revisorViewModel);
			}

			_revisorAppService.Add(revisorViewModel);
			ViewBag.AreaId = new SelectList(areaViewModel, "AreaId", "Descricao");
			return RedirectToAction("Index");
		}

		public ActionResult Edit(Guid id)
		{
			var revisor = _revisorAppService.GetById(id);
			return View(revisor);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(RevisorViewModel revisorViewModel)
		{
			if (!ModelState.IsValid) return View(revisorViewModel);
			_revisorAppService.Update(revisorViewModel);
			return RedirectToAction("Index");
		}

		public ActionResult Delete(Guid id)
		{
			var revisor = _revisorAppService.GetById(id);
			return View(revisor);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			_revisorAppService.Remove(id);
			return RedirectToAction("Index");
		}
	}
}
