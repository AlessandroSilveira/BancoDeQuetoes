using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class FormacaoRevisorController : Controller
    {
        private readonly FormacaoRevisorAppService _formacaoRevisorAppService;

        public FormacaoRevisorController(FormacaoRevisorAppService formacaoRevisorAppService)
        {
            _formacaoRevisorAppService = formacaoRevisorAppService;
        }

        // GET: FormacaoRevisor
        public ActionResult Index(int id)
        {
	        ViewBag.RevisorId = id;
			

			return View(_formacaoRevisorAppService.GetAll());
		}

      
        public ActionResult Details(Guid id)
        {
			var formacao = _formacaoRevisorAppService.GetById(id);
			
	        return formacao == null ? (ActionResult) HttpNotFound() : View(formacao);
        }

     
        public ActionResult Create(int id)
        {
			ViewBag.RevisorId = id;
			return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( RevisorFormacaoViewModel formacaoRevisorViewModel)
        {
			if (!ModelState.IsValid) return View(formacaoRevisorViewModel);
			
			_formacaoRevisorAppService.Add(formacaoRevisorViewModel);
	      
			return RedirectToAction("Index",new {id=formacaoRevisorViewModel.RevisorId});
		}

       public ActionResult Edit(Guid id)
        {
			var formacao = _formacaoRevisorAppService.GetById(id);
			return View(formacao);
		}
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( RevisorFormacaoViewModel formacaoRevisorViewModel)
        {
			if (!ModelState.IsValid) return View(formacaoRevisorViewModel);
			_formacaoRevisorAppService.Update(formacaoRevisorViewModel);
			return RedirectToAction("Index",new { id = formacaoRevisorViewModel.RevisorId });
		}

       
        public ActionResult Delete(Guid id)
        {
			var formacao = _formacaoRevisorAppService.GetById(id);
			return View(formacao);
		}

        // POST: FormacaoRevisor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
			var area = _formacaoRevisorAppService.GetById(id);
			_formacaoRevisorAppService.Remove(id);
			return RedirectToAction("Index", new { id = area.RevisorId });
		}

       
    }
}
