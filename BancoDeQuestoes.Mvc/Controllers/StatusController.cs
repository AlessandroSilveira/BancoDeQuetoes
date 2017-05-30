using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class StatusController : Controller
    {
        private readonly IStatusAppService _statusAppService;

        public StatusController(IStatusAppService statusAppService)
        {
            _statusAppService = statusAppService;
        }

        public ActionResult Index()
        {
            var dados = _statusAppService.GetAll();
            return View(dados);
        }

        public ActionResult Details(Guid id)
        {
            var status = _statusAppService.GetById(id);
            return status == null ? (ActionResult) HttpNotFound() : View(status);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StatusViewModel statusViewModel)
        {
            if (!ModelState.IsValid) return RedirectToAction("Index");
            _statusAppService.Add(statusViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            var status = _statusAppService.GetById(id);
            return View(status);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StatusId,Nome,Ativo")] StatusViewModel statusViewModel)
        {
            if (!ModelState.IsValid)
                return View(statusViewModel);

            _statusAppService.Update(statusViewModel);
            var status = _statusAppService.GetAll();
            return View("Index", status);
        }

        public ActionResult Delete(Guid id)
        {
            var status = _statusAppService.GetById(id);
            return View(status);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _statusAppService.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _statusAppService.Dispose();
            base.Dispose(disposing);
        }
    }
}
