using System.Collections.Generic;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Infra.Data.Repositories;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class RevisorController : Controller
    {
	    public RevisorController(IRevisorRepository revisorRepository)
	    {
		    RevisorRepository = revisorRepository;
	    }

	    private IRevisorRepository RevisorRepository { get; set; }
		
        public ActionResult Index()
        {
	        var repositorviewModel =
		        Mapper.Map<IEnumerable<Revisor>, IEnumerable<RevisorViewModel>>(RevisorRepository.GetAll());
            return View(repositorviewModel);
        }
        
        public ActionResult Details(int id)
        {
			var revisor = RevisorRepository.GetById(id);
			var revisorViewModel = Mapper.Map<Revisor, RevisorViewModel>(revisor);
			if (revisorViewModel == null)
			{
				return HttpNotFound();
			}
			return View(revisorViewModel);
		}
		
        public ActionResult Create()
        {
            return View();
        }
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( RevisorViewModel revisorViewModel)
        {
			if (!ModelState.IsValid) return View(revisorViewModel);
			var revisor = Mapper.Map<RevisorViewModel, Revisor>(revisorViewModel);
			RevisorRepository.Add(revisor);
			return RedirectToAction("Index");
		}
		
        public ActionResult Edit(int id)
        {
			var revisor = RevisorRepository.GetById(id);
			var revisorViewModel = Mapper.Map<Revisor, RevisorViewModel>(revisor);
			return View(revisorViewModel);
		}
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( RevisorViewModel revisorViewModel)
        {
			if (!ModelState.IsValid) return View(revisorViewModel);
			var revisorDomain = Mapper.Map<RevisorViewModel, Revisor>(revisorViewModel);
			RevisorRepository.Update(revisorDomain);

			return RedirectToAction("Index");
		}
		
        public ActionResult Delete(int id)
        {
			var revisor = RevisorRepository.GetById(id);
			var revisorViewModel = Mapper.Map<Revisor, RevisorViewModel>(revisor);

			return View(revisorViewModel);
		}
		
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var revisor = RevisorRepository.GetById(id);
			RevisorRepository.Remove(revisor);

			return RedirectToAction("Index");
		}
    }
}
