using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class AreaController : Controller
    {
	    public AreaController(IAreaRepository areaRepository)
	    {
		    AreaRepository = areaRepository;
	    }

	    private IAreaRepository AreaRepository { get; set; }
       
        public ActionResult Index()
        {
			var areaViewModel =
			   Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(AreaRepository.GetAll());
			return View(areaViewModel);
        }
       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
			var area = AreaRepository.GetById(Convert.ToInt32(id));
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
            if (ModelState.IsValid)
            {
				var area = Mapper.Map< AreaViewModel, Area>(areaViewModel);
				AreaRepository.Add(area);

				return RedirectToAction("Index");
            }

            return View(areaViewModel);
        }
       
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
			var area = AreaRepository.GetById(Convert.ToInt32(id));
			var areaViewModel = Mapper.Map<Area, AreaViewModel>(area);
			return View(areaViewModel);
		}
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AreaId,Descricao,ConhecimentoEspecifico,Ativo")] AreaViewModel areaViewModel)
        {
	        if (!ModelState.IsValid) return View(areaViewModel);
	        var areaDomain = Mapper.Map<AreaViewModel, Area>(areaViewModel);
	        AreaRepository.Update(areaDomain);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Delete(int? id)
        {
			var area = AreaRepository.GetById(Convert.ToInt32(id));
			var areaViewModel = Mapper.Map<Area, AreaViewModel>(area);

			return View(areaViewModel);
		}
      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

			var produto = AreaRepository.GetById(id);
			AreaRepository.Remove(produto);
			
			return RedirectToAction("Index");
		}
    }
}
