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
	public class ProjetoController : Controller
    {
	    private readonly IProjetoAppService _projetoAppService;
	  

		public ProjetoController(IProjetoAppService projetoAppService)
		{
			_projetoAppService = projetoAppService;
			
		}
		
	    public ActionResult Index()
        {
			var projetoViewModel =
			   Mapper.Map<IEnumerable<Projeto>, IEnumerable<ProjetoViewModel>>(_projetoAppService.GetAll());



			return View("Index",projetoViewModel);
        }
        
        public ActionResult Details(int id)
        {
			var projeto = _projetoAppService.GetById(id);
			var projetoViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);
	        return projetoViewModel == null ? (ActionResult) HttpNotFound() : View(projetoViewModel);
        }
       
        public ActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjetoViewModel projetoViewModel)
        {
	        if (!ModelState.IsValid) return View(projetoViewModel);
	        var projeto = Mapper.Map<ProjetoViewModel, Projeto>(projetoViewModel);
			_projetoAppService.Add(projeto);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Edit(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var projeto = _projetoAppService.GetById(Convert.ToInt32(id));
	        var projetosViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);
	        return View(projetosViewModel);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjetoViewModel projetoViewModel)
        {
			if (!ModelState.IsValid) return View(projetoViewModel);
			var projetoDomain = Mapper.Map<ProjetoViewModel, Projeto>(projetoViewModel);
			_projetoAppService.Update(projetoDomain);

			return RedirectToAction("Index");
		}
		
        public ActionResult Delete(int? id)
		{
			var projeto = _projetoAppService.GetById(Convert.ToInt32(id));
			var projetoViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);

			return View(projetoViewModel);
		}
       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var projeto = _projetoAppService.GetById(id);
			_projetoAppService.Remove(projeto);

			return RedirectToAction("Index");
		}
    }
}
