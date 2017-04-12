using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class MestreFormacaoController : Controller
	{
		private readonly IMestreFormacaoAppService _mestreFormacaoAppService;

		public MestreFormacaoController(IMestreFormacaoAppService mestreFormacaoAppService)
		{
			_mestreFormacaoAppService = mestreFormacaoAppService;
		}
		
        public ActionResult Index(int id)
        {
	        ViewBag.MestreId = id;
			var mestreViewModel =
			   Mapper.Map<IEnumerable<MestreFormacao>, IEnumerable<MestreFormacaoViewModel>>(_mestreFormacaoAppService.GetAll());
			return View(mestreViewModel);
        }
		
        public ActionResult Details(int? id)
        {
			if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			var mestre = _mestreFormacaoAppService.GetById(Convert.ToInt32(id));
			var mestreDependenteViewModel = Mapper.Map<MestreFormacao, MestreFormacaoViewModel>(mestre);

			return mestreDependenteViewModel == null ? (ActionResult)HttpNotFound() : View(mestreDependenteViewModel);
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
			var mestre = Mapper.Map<MestreFormacaoViewModel, MestreFormacao>(mestreFormacaoViewModel);
			_mestreFormacaoAppService.Add(mestre);

			return RedirectToAction("Index",new {id= mestreFormacaoViewModel.MestreId});
		}
        
        public ActionResult Edit(int? id)
        {
			if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			var mestre = _mestreFormacaoAppService.GetById(Convert.ToInt32(id));
			var mestreDependenteViewModel = Mapper.Map<MestreFormacao, MestreFormacaoViewModel>(mestre);

			return mestreDependenteViewModel == null ? (ActionResult)HttpNotFound() : View(mestreDependenteViewModel);
		}
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MestreFormacaoViewModel mestreFormacaoViewModel)
        {
			if (!ModelState.IsValid) return View(mestreFormacaoViewModel);
			var mestreDomain = Mapper.Map<MestreFormacaoViewModel, MestreFormacao>(mestreFormacaoViewModel);
			_mestreFormacaoAppService.Update(mestreDomain);

			return RedirectToAction("Index",new {id= mestreFormacaoViewModel .MestreId});
		}
		
        public ActionResult Delete(int? id)
        {
			if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			var mestre = _mestreFormacaoAppService.GetById(Convert.ToInt32(id));
			var mestreDependenteViewModel = Mapper.Map<MestreFormacao, MestreFormacaoViewModel>(mestre);
			ViewBag.MestreId = id;

			return mestreDependenteViewModel == null ? (ActionResult)HttpNotFound() : View(mestreDependenteViewModel);
		}
		
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var mestre = _mestreFormacaoAppService.GetById(id);
			_mestreFormacaoAppService.Remove(mestre);
			return RedirectToAction("Index");
        }
    }
}
