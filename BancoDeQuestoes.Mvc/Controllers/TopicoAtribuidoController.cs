using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class TopicoAtribuidoController : Controller
	{
		private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;

		public TopicoAtribuidoController(ITopicoAtribuidoAppService topicoAtribuidoAppService)
		{
			_topicoAtribuidoAppService = topicoAtribuidoAppService;
		}

		
        public ActionResult Index()
        {
			var topicoAtribuidoViewModel =
		   Mapper.Map<IEnumerable<TopicoAtribuido>, IEnumerable<TopicoAtribuidoViewModel>>(_topicoAtribuidoAppService.GetAll());
			return View(topicoAtribuidoViewModel);
		}

       
        public ActionResult Details(int? id)
        {
			var topico = _topicoAtribuidoAppService.GetById(Convert.ToInt32(id));
			var topicoViewModel = Mapper.Map<TopicoAtribuido, TopicoAtribuidoViewModel>(topico);
			return topicoViewModel == null ? (ActionResult)HttpNotFound() : View(topicoViewModel);
			
        }
       
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TopicoAtribuidoViewModel topicoAtribuidoViewModel)
        {
			if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
			var topico = Mapper.Map<TopicoAtribuidoViewModel, TopicoAtribuido>(topicoAtribuidoViewModel);
			_topicoAtribuidoAppService.Add(topico);

			return RedirectToAction("Index");
		}
       
        public ActionResult Edit(int id)
        {
			var topico = _topicoAtribuidoAppService.GetById(Convert.ToInt32(id));
			var topicoViewModel = Mapper.Map<TopicoAtribuido, TopicoAtribuidoViewModel>(topico);
			return View(topicoViewModel);
		}
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( TopicoAtribuidoViewModel topicoAtribuidoViewModel)
        {
			if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
			var topicoDomain = Mapper.Map<TopicoAtribuidoViewModel, TopicoAtribuido>(topicoAtribuidoViewModel);
			_topicoAtribuidoAppService.Update(topicoDomain);

			return RedirectToAction("Index");
		}
        
        public ActionResult Delete(int id)
        {
			var topico = _topicoAtribuidoAppService.GetById(id);
			var topicoAtribuidoViewModel = Mapper.Map<TopicoAtribuido, TopicoAtribuidoViewModel>(topico);
			return View(topicoAtribuidoViewModel);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var topico = _topicoAtribuidoAppService.GetById(id);
			_topicoAtribuidoAppService.Remove(topico);
			return RedirectToAction("Index");
        }
    }
}
