using System.Collections.Generic;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Infra.Data.Repositories;
using BancoDeQuestoes.Mvc.ViewModels;

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
	        var repositorviewModel =
		        Mapper.Map<IEnumerable<Revisor>, IEnumerable<RevisorViewModel>>(_revisorAppService.GetAll());
            return View(repositorviewModel);
        }
        
        public ActionResult Details(int id)
        {
			var revisor = _revisorAppService.GetById(id);
			var revisorViewModel = Mapper.Map<Revisor, RevisorViewModel>(revisor);
			if (revisorViewModel == null)
			{
				return HttpNotFound();
			}
			return View(revisorViewModel);
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
        public ActionResult Create( RevisorViewModel revisorViewModel)
        {
			if (!ModelState.IsValid) return View(revisorViewModel);
			var revisor = Mapper.Map<RevisorViewModel, Revisor>(revisorViewModel);
			_revisorAppService.Add(revisor);
			return RedirectToAction("Index");
		}
		
        public ActionResult Edit(int id)
        {
			var revisor = _revisorAppService.GetById(id);
			var revisorViewModel = Mapper.Map<Revisor, RevisorViewModel>(revisor);
			return View(revisorViewModel);
		}
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( RevisorViewModel revisorViewModel)
        {
			if (!ModelState.IsValid) return View(revisorViewModel);
			var revisorDomain = Mapper.Map<RevisorViewModel, Revisor>(revisorViewModel);
			_revisorAppService.Update(revisorDomain);

			return RedirectToAction("Index");
		}
		
        public ActionResult Delete(int id)
        {
			var revisor = _revisorAppService.GetById(id);
			var revisorViewModel = Mapper.Map<Revisor, RevisorViewModel>(revisor);

			return View(revisorViewModel);
		}
		
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var revisor = _revisorAppService.GetById(id);
			_revisorAppService.Remove(revisor);

			return RedirectToAction("Index");
		}
    }
}
