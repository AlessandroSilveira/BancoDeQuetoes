using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class MestreDependenteController : Controller
	{
	    private MestreDependenteAppService _mestreDependenteAppService;

	    public MestreDependenteController(MestreDependenteAppService mestreDependenteAppService)
	    {
	        _mestreDependenteAppService = mestreDependenteAppService;
	    }

	    public ActionResult Index(int id)
        {
			ViewBag.MestreId = id;
		    return View(_mestreDependenteAppService.GetAll());
        }
       
        public ActionResult Details(Guid id)
        {
	        var mestre = _mestreDependenteAppService.GetById(id);
	        return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }
        
        public ActionResult Create(int id)
        {
			ViewBag.MestreId = id;
			return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MestreDependenteViewModel mestreDependenteViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreDependenteViewModel);
	        _mestreDependenteAppService.Add(mestreDependenteViewModel);
	        return RedirectToAction("Index", new { id = mestreDependenteViewModel.MestreId });
        }
      
        public ActionResult Edit(Guid id)
        {
	        var mestre = _mestreDependenteAppService.GetById(id);
	        return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( MestreDependenteViewModel mestreDependenteViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreDependenteViewModel);
	        _mestreDependenteAppService.Update(mestreDependenteViewModel);
	        return RedirectToAction("Index", new { id = mestreDependenteViewModel.MestreId });
        }
       
        public ActionResult Delete(Guid id)
        {
			ViewBag.MestreId = id;
			var mestre = _mestreDependenteAppService.GetById(id);
	        return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
			_mestreDependenteAppService.Remove(id);
			return RedirectToAction("Index");
        }
    }
}
