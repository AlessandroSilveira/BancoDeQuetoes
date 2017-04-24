using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class MestreController : Controller
	{
	    private readonly IMestreAppService _mestreAppService;

	    public MestreController(IMestreAppService mestreAppService)
	    {
	        _mestreAppService = mestreAppService;
	    }

	    public ActionResult Index()
        {
			return View(_mestreAppService.GetAll());
        }
        
        public ActionResult Details(Guid id)
        {
	        var mestre = _mestreAppService.GetById(id);
	        return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }
       
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MestreViewModel mestreViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreViewModel);
	        _mestreAppService.Add(mestreViewModel);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Edit(Guid id)
        {
	        var mestre = _mestreAppService.GetById(id);
	        return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( MestreViewModel mestreViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreViewModel);
	        _mestreAppService.Update(mestreViewModel);
	        return RedirectToAction("Index");
        }
       
        public ActionResult Delete(Guid id)
        {
            var mestre = _mestreAppService.GetById(id);
            return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
			_mestreAppService.Remove(id);
			return RedirectToAction("Index");
        }
    }
}
