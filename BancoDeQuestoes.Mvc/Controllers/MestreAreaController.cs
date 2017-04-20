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
	public class MestreAreaController : Controller
	{
		private readonly IMestreAreaAppService _mestreAreaAppService;

		public MestreAreaController(IMestreAreaAppService mestreAreaAppService)
		{
			_mestreAreaAppService = mestreAreaAppService;
		}
	
        public ActionResult Index(int id)
        {
			ViewBag.MestreId = id;
			var mestreViewModel =
			   Mapper.Map<IEnumerable<MestreArea>, IEnumerable<MestreAreaViewModel>>(_mestreAreaAppService.GetAll());

			return View(mestreViewModel);
        }

       
        public ActionResult Details(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

	        var mestre = _mestreAreaAppService.GetById(Convert.ToInt32(id));
	        var mestreAreaViewModel = Mapper.Map<MestreArea, MestreAreaViewModel>(mestre);

	        return mestreAreaViewModel == null ? (ActionResult) HttpNotFound() : View(mestreAreaViewModel);
        }

		public ActionResult Create(int id)
		{
			ViewBag.MestreId = id;
			return View();
		}

		[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MestreAreaViewModel mestreAreaViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreAreaViewModel);

	        var mestre = Mapper.Map<MestreAreaViewModel, MestreArea>(mestreAreaViewModel);
	        _mestreAreaAppService.Add(mestre);

			return RedirectToAction("Index", new { id = mestreAreaViewModel.MestreId });
		}
        
        public ActionResult Edit(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

	        var mestre = _mestreAreaAppService.GetById(Convert.ToInt32(id));
	        var mestreAreaViewModel = Mapper.Map<MestreArea, MestreAreaViewModel>(mestre);

	        return mestreAreaViewModel == null ? (ActionResult) HttpNotFound() : View(mestreAreaViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( MestreAreaViewModel mestreAreaViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreAreaViewModel);

	        var mestreDomain = Mapper.Map<MestreAreaViewModel, MestreArea>(mestreAreaViewModel);
	        _mestreAreaAppService.Update(mestreDomain);

			return RedirectToAction("Index", new { id = mestreAreaViewModel.MestreId });
		}
		
        public ActionResult Delete(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var mestre = _mestreAreaAppService.GetById(Convert.ToInt32(id));
	        var mestreAreaViewModel = Mapper.Map<MestreArea, MestreAreaViewModel>(mestre);
			ViewBag.MestreId = id;
			return mestreAreaViewModel == null ? (ActionResult) HttpNotFound() : View(mestreAreaViewModel);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var mestre = _mestreAreaAppService.GetById(id);
			_mestreAreaAppService.Remove(mestre);

			return RedirectToAction("Index");
        }
    }
}
