using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class MestreController : Controller
	{
		private readonly IMestreAppService _mestreAppService;

		public MestreController(IMestreAppService mestreAppService)
		{
			_mestreAppService = mestreAppService;
		}
		
        public ActionResult Index()
        {
			var mestreViewModel =
			   Mapper.Map<IEnumerable<Mestre>, IEnumerable<MestreViewModel>>(_mestreAppService.GetAll());

			return View(mestreViewModel);
        }
        
        public ActionResult Details(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var mestre = _mestreAppService.GetById(Convert.ToInt32(id));
	        var mestreViewModel = Mapper.Map<Mestre, MestreViewModel>(mestre);

	        return mestreViewModel == null ? (ActionResult) HttpNotFound() : View(mestreViewModel);
        }
       
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MestreViewModel mestreViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreViewModel);
	        var mestre = Mapper.Map<MestreViewModel, Mestre>(mestreViewModel);
	        _mestreAppService.Add(mestre);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Edit(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var mestre = _mestreAppService.GetById(Convert.ToInt32(id));
	        var mestreViewModel = Mapper.Map<Mestre, MestreViewModel>(mestre);

	        return mestreViewModel == null ? (ActionResult) HttpNotFound() : View(mestreViewModel);
        }
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( MestreViewModel mestreViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreViewModel);
	        var mestreDomain = Mapper.Map<MestreViewModel, Mestre>(mestreViewModel);
	        _mestreAppService.Update(mestreDomain);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
			var mestre = _mestreAppService.GetById(Convert.ToInt32(id));
			var mestreViewModel = Mapper.Map<Mestre, MestreViewModel>(mestre);
			if (mestreViewModel == null)
            {
                return HttpNotFound();
            }

            return View(mestreViewModel);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var mestre = _mestreAppService.GetById(id);
			_mestreAppService.Remove(mestre);

			return RedirectToAction("Index");
        }
    }
}
