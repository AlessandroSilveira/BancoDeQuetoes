using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

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
			var projetoViewModel = _projetoAppService.GetAll();
			return View("Index",projetoViewModel);
        }
        
        public ActionResult Details(Guid id)
        {
			var projeto = _projetoAppService.GetById(id);
	        return projeto == null ? (ActionResult) HttpNotFound() : View(projeto);
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
	        _projetoAppService.Add(projetoViewModel);
	        return RedirectToAction("Index");
        }
       
        public ActionResult Edit(Guid id)
        {
	        var projeto = _projetoAppService.GetById(id);
	        return View(projeto);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjetoViewModel projetoViewModel)
        {
			if (!ModelState.IsValid) return View(projetoViewModel);
			_projetoAppService.Update(projetoViewModel);
			return RedirectToAction("Index");
		}
		
        public ActionResult Delete(Guid id)
		{
			var projeto = _projetoAppService.GetById(id);
			return View(projeto);
		}
       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
			_projetoAppService.Remove(id);
			return RedirectToAction("Index");
		}
    }
}
