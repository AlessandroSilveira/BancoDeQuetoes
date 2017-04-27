using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class MestreController : Controller
	{
	    private readonly IMestreAppService _mestreAppService;
		private readonly IBancaAppService _bancaAppService;

	    public MestreController(IMestreAppService mestreAppService, IBancaAppService bancaAppService)
	    {
		    _mestreAppService = mestreAppService;
		    _bancaAppService = bancaAppService;
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
			ViewBag.BancaId = new SelectList(_bancaAppService.GetAll(),"BancaId","Nome") ;
			return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MestreViewModel mestreViewModel)
        {
	        if (!ModelState.IsValid)
	        {
				ViewBag.BancaId = new SelectList(_bancaAppService.GetAll(), "BancaId", "Nome");
				return View(mestreViewModel);
	        }
	        _mestreAppService.Add(mestreViewModel);
			ViewBag.BancaId = new SelectList(_bancaAppService.GetAll(), "BancaId", "Nome");
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
