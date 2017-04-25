using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class MestreFormacaoController : Controller
	{
	    private readonly IMestreFormacaoAppService _mestreFormacaoAppService;
		private readonly IMestreAppService _mestreAppService;

	    public MestreFormacaoController(IMestreFormacaoAppService mestreFormacaoAppService, IMestreAppService mestreAppService)
	    {
		    _mestreFormacaoAppService = mestreFormacaoAppService;
		    _mestreAppService = mestreAppService;
	    }

	    public ActionResult Index(Guid id)
        {
	        ViewBag.MestreId = id;
	        ViewBag.DadosMestre = _mestreAppService.GetById(id);
			return View(_mestreFormacaoAppService.GetAll());
        }
		
        public ActionResult Details(Guid id)
        {
			var mestre = _mestreFormacaoAppService.GetById(id);
			ViewBag.DadosMestre = _mestreAppService.GetById(mestre.MestreId);
			return mestre == null ? (ActionResult)HttpNotFound() : View(mestre);
		}
		
        public ActionResult Create(Guid id)
        {
	        ViewBag.MestreId = id;
	        ViewBag.TipoFormacao = new SelectList(new ListaFormacao().Formacoes(), "Key", "Value", "Selecione");
            return View();
        }
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MestreFormacaoViewModel mestreFormacaoViewModel)
        {
			if (!ModelState.IsValid) return View(mestreFormacaoViewModel);
			_mestreFormacaoAppService.Add(mestreFormacaoViewModel);
			return RedirectToAction("Index",new {id= mestreFormacaoViewModel.MestreId});
		}
        
        public ActionResult Edit(Guid id)
        {
			
			var mestre = _mestreFormacaoAppService.GetById(id);
			ViewBag.DadosMestre = _mestreAppService.GetById(mestre.MestreId);

			return mestre == null ? (ActionResult)HttpNotFound() : View(mestre);
		}
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MestreFormacaoViewModel mestreFormacaoViewModel)
        {
			if (!ModelState.IsValid) return View(mestreFormacaoViewModel);
			_mestreFormacaoAppService.Update(mestreFormacaoViewModel);
			ViewBag.DadosMestre = _mestreAppService.GetById(mestreFormacaoViewModel.MestreId);
			return RedirectToAction("Index",new {id= mestreFormacaoViewModel .MestreId});
		}
		
        public ActionResult Delete(Guid id)
        {
			var mestre = _mestreFormacaoAppService.GetById(id);
			ViewBag.MestreId = id;
			ViewBag.DadosMestre = _mestreAppService.GetById(mestre.MestreId);
			return mestre == null ? (ActionResult)HttpNotFound() : View(mestre);
		}
		
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
		
			_mestreFormacaoAppService.Remove(id);
			return RedirectToAction("Index");
        }
    }
}
