using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class FormacaoRevisorController : Controller
    {
	    private readonly IFormacaoRevisorAppService _formacaoRevisorAppService;

	    public FormacaoRevisorController(IFormacaoRevisorAppService formacaoRevisorAppService)
	    {
		    _formacaoRevisorAppService = formacaoRevisorAppService;
	    }


	    // GET: FormacaoRevisor
        public ActionResult Index(int id)
        {
	        ViewBag.RevisorId = id;
			var formacaoViewModel =
				 Mapper.Map<IEnumerable<RevisorFormacao>, IEnumerable<FormacaoRevisorViewModel>>(_formacaoRevisorAppService.GetAll());

			return View(formacaoViewModel);
		}

      
        public ActionResult Details(int? id)
        {
			var formacao = _formacaoRevisorAppService.GetById(Convert.ToInt32(id));
			var formacaoViewModel = Mapper.Map<RevisorFormacao, FormacaoRevisorViewModel>(formacao);
	        return formacaoViewModel == null ? (ActionResult) HttpNotFound() : View(formacaoViewModel);
        }

     
        public ActionResult Create(int id)
        {
			ViewBag.RevisorId = id;
			return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( FormacaoRevisorViewModel formacaoRevisorViewModel)
        {
			if (!ModelState.IsValid) return View(formacaoRevisorViewModel);
			var formacao = Mapper.Map<FormacaoRevisorViewModel, RevisorFormacao>(formacaoRevisorViewModel);
			_formacaoRevisorAppService.Add(formacao);
	      
			return RedirectToAction("Index",new {id=formacaoRevisorViewModel.RevisorId});
		}

       public ActionResult Edit(int? id)
        {
			var formacao = _formacaoRevisorAppService.GetById(Convert.ToInt32(id));
			var formacaoViewModel = Mapper.Map<RevisorFormacao, FormacaoRevisorViewModel>(formacao);
			return View(formacaoViewModel);
		}
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( FormacaoRevisorViewModel formacaoRevisorViewModel)
        {
			if (!ModelState.IsValid) return View(formacaoRevisorViewModel);
			var formacaoDomain = Mapper.Map<FormacaoRevisorViewModel, RevisorFormacao>(formacaoRevisorViewModel);
			_formacaoRevisorAppService.Update(formacaoDomain);

			return RedirectToAction("Index",new { id = formacaoRevisorViewModel.RevisorId });
		}

       
        public ActionResult Delete(int? id)
        {
			var formacao = _formacaoRevisorAppService.GetById(Convert.ToInt32(id));
			var formacaoViewModel = Mapper.Map<RevisorFormacao, FormacaoRevisorViewModel>(formacao);
			return View(formacaoViewModel);
		}

        // POST: FormacaoRevisor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var area = _formacaoRevisorAppService.GetById(id);
			_formacaoRevisorAppService.Remove(area);
			return RedirectToAction("Index", new { id = area.RevisorId });
		}

       
    }
}
