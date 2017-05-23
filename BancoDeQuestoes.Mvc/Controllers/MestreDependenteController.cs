using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class MestreDependenteController : Controller
	{
	    private readonly IMestreDependenteAppService _mestreDependenteAppService;
		private readonly IMestreAppService _mestreAppService;

	    public MestreDependenteController(IMestreDependenteAppService mestreDependenteAppService, IMestreAppService mestreAppService)
	    {
		    _mestreDependenteAppService = mestreDependenteAppService;
		    _mestreAppService = mestreAppService;
	    }

	    public ActionResult Index(Guid id)
        {
			ViewBag.MestreId = id;
			ViewBag.DadosMestre = _mestreAppService.GetById(id);
			return View(_mestreDependenteAppService.GetAll());
        }
       
        public ActionResult Details(Guid id)
        {
	        var mestre = _mestreDependenteAppService.GetById(id);
			ViewBag.DadosMestre = _mestreAppService.GetById(mestre.MestreId);
			return View(mestre);
        }
        
        public ActionResult Create(Guid id)
        {
			ViewBag.MestreId = id;
			ViewBag.DadosMestre = _mestreAppService.GetById(id);
			return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MestreDependenteViewModel mestreDependenteViewModel)
        {
	        if (!ModelState.IsValid)
	        {
				ViewBag.DadosMestre = _mestreAppService.GetById(mestreDependenteViewModel.MestreId);
				return View(mestreDependenteViewModel);
	        }
	        _mestreDependenteAppService.Add(mestreDependenteViewModel);
			ViewBag.DadosMestre = _mestreAppService.GetById(mestreDependenteViewModel.MestreId);
			return RedirectToAction("Index", new { id = mestreDependenteViewModel.MestreId });
        }
      
        public ActionResult Edit(Guid id)
        {
	        var mestre = _mestreDependenteAppService.GetById(id);
			ViewBag.DadosMestre = _mestreAppService.GetById(mestre.MestreId);
			return View(mestre);
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( MestreDependenteViewModel mestreDependenteViewModel)
        {
	        if (!ModelState.IsValid) return View(mestreDependenteViewModel);
	        _mestreDependenteAppService.Update(mestreDependenteViewModel);
			ViewBag.DadosMestre = _mestreAppService.GetById(mestreDependenteViewModel.MestreId);
			return RedirectToAction("Index", new { id = mestreDependenteViewModel.MestreId });
        }
       
        public ActionResult Delete(Guid id)
        {
			ViewBag.MestreId = id;
			var mestre = _mestreDependenteAppService.GetById(id);
			ViewBag.DadosMestre = _mestreAppService.GetById(mestre.MestreId);
			return View(mestre);
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
