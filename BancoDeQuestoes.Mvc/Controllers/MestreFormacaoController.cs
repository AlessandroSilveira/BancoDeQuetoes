﻿using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class MestreFormacaoController : Controller
	{
	    private readonly MestreFormacaoAppService _mestreFormacaoAppService;

	    public MestreFormacaoController(MestreFormacaoAppService mestreFormacaoAppService)
	    {
	        _mestreFormacaoAppService = mestreFormacaoAppService;
	    }

	    public ActionResult Index(int id)
        {
	        ViewBag.MestreId = id;
			return View(_mestreFormacaoAppService.GetAll());
        }
		
        public ActionResult Details(Guid id)
        {
			var mestre = _mestreFormacaoAppService.GetById(id);
			return mestre == null ? (ActionResult)HttpNotFound() : View(mestre);
		}
		
        public ActionResult Create(int id)
        {
	        ViewBag.MestreId = id;
            return View();
        }
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MestreFormacaoViewModel mestreFormacaoViewModel)
        {
			if (!ModelState.IsValid) return View(mestreFormacaoViewModel);
			_mestreFormacaoAppService.Add(mestreFormacaoViewModel);
			return RedirectToAction("Index",new {id= mestreFormacaoViewModel.MestreId});
		}
        
        public ActionResult Edit(Guid id)
        {
			
			var mestre = _mestreFormacaoAppService.GetById(id);
			

			return mestre == null ? (ActionResult)HttpNotFound() : View(mestre);
		}
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MestreFormacaoViewModel mestreFormacaoViewModel)
        {
			if (!ModelState.IsValid) return View(mestreFormacaoViewModel);
			_mestreFormacaoAppService.Update(mestreFormacaoViewModel);
			return RedirectToAction("Index",new {id= mestreFormacaoViewModel .MestreId});
		}
		
        public ActionResult Delete(Guid id)
        {
			var mestre = _mestreFormacaoAppService.GetById(id);
			ViewBag.MestreId = id;
			return mestre == null ? (ActionResult)HttpNotFound() : View(mestre);
		}
		
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
		
			_mestreFormacaoAppService.Remove(id);
			return RedirectToAction("Index");
        }
    }
}
