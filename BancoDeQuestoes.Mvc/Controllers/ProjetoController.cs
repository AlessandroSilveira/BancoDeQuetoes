using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Infra.Data.Context;
using BancoDeQuestoes.Infra.Data.Repositories;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class ProjetoController : Controller
    {
	    public ProjetoController(IProjetoRepository projetoRepository)
	    {
		    this.ProjetoRepository = projetoRepository;
	    }

	    private IProjetoRepository ProjetoRepository { get; set; }

        // GET: Projeto
        public ActionResult Index()
        {
			var projetoViewModel =
			   Mapper.Map<IEnumerable<Projeto>, IEnumerable<ProjetoViewModel>>(ProjetoRepository.GetAll());
			return View(projetoViewModel);
        }
        
        public ActionResult Details(int? id)
        {
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			var projeto = ProjetoRepository.GetById(Convert.ToInt32(id));
			var projetoViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);
			if (projetoViewModel == null)
			{
				return HttpNotFound();
			}
			return View(projetoViewModel);
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
	        ProjetoRepository.Add(projeto);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Edit(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var projeto = ProjetoRepository.GetById(Convert.ToInt32(id));
	        var projetosViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);
	        return View(projetosViewModel);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjetoViewModel projetoViewModel)
        {
			if (!ModelState.IsValid) return View(projetoViewModel);
			var projetoDomain = Mapper.Map<ProjetoViewModel, Projeto>(projetoViewModel);
			ProjetoRepository.Update(projetoDomain);

			return RedirectToAction("Index");
		}
		
        public ActionResult Delete(int? id)
		{
			var projeto = ProjetoRepository.GetById(Convert.ToInt32(id));
			var projetoViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);

			return View(projetoViewModel);
		}
       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var projeto = ProjetoRepository.GetById(id);
			ProjetoRepository.Remove(projeto);

			return RedirectToAction("Index");
		}
    }
}
