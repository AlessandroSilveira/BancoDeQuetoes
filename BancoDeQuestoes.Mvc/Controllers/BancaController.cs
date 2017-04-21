using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class BancaController : Controller
    {
	    private readonly IBancaAppService _bancaAppService;

	    public BancaController(IBancaAppService bancaAppService)
	    {
		    _bancaAppService = bancaAppService;
	    }
	   
        public ActionResult Index()
        {
			var bancaViewModel =
			   Mapper.Map<IEnumerable<Banca>, IEnumerable<BancaViewModel>>(_bancaAppService.GetAll());
			return View(bancaViewModel);
        }
      
        public ActionResult Details(int id)
        {
			var banca = _bancaAppService.GetById(Convert.ToInt32(id));
			var bancaViewModel = Mapper.Map<Banca, BancaViewModel>(banca);
	        return bancaViewModel == null ? (ActionResult) HttpNotFound() : View(bancaViewModel);
        }
        
        public ActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BancaViewModel bancaViewModel)
        {
	        if (!ModelState.IsValid) return View(bancaViewModel);
	        var banca = Mapper.Map<BancaViewModel, Banca>(bancaViewModel);
	        _bancaAppService.Add(banca);

	        return RedirectToAction("Index");
        }
        
        public ActionResult Edit(int id)
        {

			var banca = _bancaAppService.GetById(Convert.ToInt32(id));
			var bancaViewModel = Mapper.Map<Banca, BancaViewModel>(banca);
			return View(bancaViewModel);
		}
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BancaViewModel bancaViewModel)
        {
			if (!ModelState.IsValid) return View(bancaViewModel);
			var bancaDomain = Mapper.Map<BancaViewModel, Banca>(bancaViewModel);
			_bancaAppService.Update(bancaDomain);

			return RedirectToAction("Index");
		}
		
        public ActionResult Delete(int id)
        {
			var banca = _bancaAppService.GetById(id);
			var bancaViewModel = Mapper.Map<Banca, BancaViewModel>(banca);

			return View(bancaViewModel);
		}
       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var banca = _bancaAppService.GetById(id);
			_bancaAppService.Remove(banca);

			return RedirectToAction("Index");
		}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
				_bancaAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
