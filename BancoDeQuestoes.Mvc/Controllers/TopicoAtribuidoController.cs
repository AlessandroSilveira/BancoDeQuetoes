using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class TopicoAtribuidoController : Controller
	{
		private readonly TopicoAtribuidoAppService _topicoAtribuidoAppService;

		public TopicoAtribuidoController(TopicoAtribuidoAppService topicoAtribuidoAppService)
		{
			_topicoAtribuidoAppService = topicoAtribuidoAppService;
		}

		
        public ActionResult Index()
        {
			return View(_topicoAtribuidoAppService.GetAll());
		}
        
        public ActionResult Details(Guid id)
        {
			var topico = _topicoAtribuidoAppService.GetById(id);
			return topico == null ? (ActionResult)HttpNotFound() : View(topico);
			
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
			_topicoAtribuidoAppService.Add(topicoAtribuidoViewModel);
			return RedirectToAction("Index");
		}
       
        public ActionResult Edit(Guid id)
        {
			var topico = _topicoAtribuidoAppService.GetById(id);
			return View(topico);
		}
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( TopicoAtribuidoViewModel topicoAtribuidoViewModel)
        {
			if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
			
			_topicoAtribuidoAppService.Update(topicoAtribuidoViewModel);
			return RedirectToAction("Index");
		}
        
        public ActionResult Delete(Guid id)
        {
			
			return View(_topicoAtribuidoAppService.GetById(id));
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
			
			_topicoAtribuidoAppService.Remove(id);
			return RedirectToAction("Index");
        }
    }
}
