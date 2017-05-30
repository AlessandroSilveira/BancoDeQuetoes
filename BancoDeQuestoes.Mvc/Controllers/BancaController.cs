using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class BancaController : Controller
    {
        private readonly IBancaAppService _bancaAppService;

        public BancaController(IBancaAppService bancaAppService)
        {
            _bancaAppService = bancaAppService;
        }

        public ActionResult Index()
        {
            return View(_bancaAppService.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            return View(_bancaAppService.GetById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BancaViewModel bancaViewModel)
        {
            _bancaAppService.Add(bancaViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            var banca = _bancaAppService.GetById(id);
            return View(banca);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BancaViewModel bancaViewModel)
        {
            if (!ModelState.IsValid) return View(bancaViewModel);
            _bancaAppService.Update(bancaViewModel);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            var banca = _bancaAppService.GetById(id);
            return View(banca);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _bancaAppService.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _bancaAppService.Dispose();
            base.Dispose(disposing);
        }
    }
}
