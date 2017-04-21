using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class AreaController : Controller
	{
		private readonly IAreaAppService _areaAppService;

		public AreaController(IAreaAppService areaAppService)
		{
			_areaAppService = areaAppService;
		}

		public ActionResult Index()
        {
			var areaViewModel =
			   Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaAppService.GetAll());
			return View(areaViewModel);
        }
       
        public ActionResult Details(int id)
        {
           
			var area = _areaAppService.GetById(Convert.ToInt32(id));
			var areaViewModel = Mapper.Map<Area, AreaViewModel>(area);
            if (areaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(areaViewModel);
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AreaViewModel areaViewModel)
        {
	        if (!ModelState.IsValid) return View(areaViewModel);
	        var area = Mapper.Map< AreaViewModel, Area>(areaViewModel);
	        _areaAppService.Add(area);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Edit(int id)
        {
           
			var area = _areaAppService.GetById(Convert.ToInt32(id));
			var areaViewModel = Mapper.Map<Area, AreaViewModel>(area);
			return View(areaViewModel);
		}
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( AreaViewModel areaViewModel)
        {
	        if (!ModelState.IsValid) return View(areaViewModel);
	        var areaDomain = Mapper.Map<AreaViewModel, Area>(areaViewModel);
			_areaAppService.Update(areaDomain);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Delete(int? id)
        {
			var area = _areaAppService.GetById(Convert.ToInt32(id));
			var areaViewModel = Mapper.Map<Area, AreaViewModel>(area);
			return View(areaViewModel);
		}
      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var area = _areaAppService.GetById(id);
			_areaAppService.Remove(area);
			return RedirectToAction("Index");
		}
    }
}
