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
	public class MestreDependenteController : Controller
	{
		private readonly IMestreDependenteAppService _mestreDependenteAppService;

		public MestreDependenteController(IMestreDependenteAppService mestreDependenteAppService)
		{
			_mestreDependenteAppService = mestreDependenteAppService;
		}
		
        public ActionResult Index()
        {
			var mestreViewModel =
			   Mapper.Map<IEnumerable<MestreDependente>, IEnumerable<MestreDependenteViewModel>>(_mestreDependenteAppService.GetAll());
			return View(mestreViewModel);
        }
       
        public ActionResult Details(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

	        var mestre = _mestreDependenteAppService.GetById(Convert.ToInt32(id));
	        var mestreDependenteViewModel = Mapper.Map<MestreDependente, MestreDependenteViewModel>(mestre);

	        return mestreDependenteViewModel == null ? (ActionResult) HttpNotFound() : View(mestreDependenteViewModel);
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MestreDependenteViewModel mestreDependenteViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreDependenteViewModel);
	        var mestre = Mapper.Map<MestreDependenteViewModel, MestreDependente>(mestreDependenteViewModel);
	        _mestreDependenteAppService.Add(mestre);

	        return RedirectToAction("Index");
        }
      
        public ActionResult Edit(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var mestre = _mestreDependenteAppService.GetById(Convert.ToInt32(id));
	        var mestreDependenteViewModel = Mapper.Map<MestreDependente, MestreDependenteViewModel>(mestre);

	        return mestreDependenteViewModel == null ? (ActionResult) HttpNotFound() : View(mestreDependenteViewModel);
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( MestreDependenteViewModel mestreDependenteViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreDependenteViewModel);
	        var mestreDomain = Mapper.Map<MestreDependenteViewModel, MestreDependente>(mestreDependenteViewModel);
	        _mestreDependenteAppService.Update(mestreDomain);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Delete(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var mestre = _mestreDependenteAppService.GetById(Convert.ToInt32(id));
	        var mestreDependenteViewModel = Mapper.Map<MestreDependente, MestreDependenteViewModel>(mestre);

	        return mestreDependenteViewModel == null ? (ActionResult) HttpNotFound() : View(mestreDependenteViewModel);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var mestre = _mestreDependenteAppService.GetById(id);
			_mestreDependenteAppService.Remove(mestre);

			return RedirectToAction("Index");
        }
    }
}
