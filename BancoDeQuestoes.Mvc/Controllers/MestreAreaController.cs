using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class MestreAreaController : Controller
    {
        private readonly MestreAreaAppService _mestreAreaAppService;

        public MestreAreaController(MestreAreaAppService mestreAreaAppService)
        {
            _mestreAreaAppService = mestreAreaAppService;
        }

        public ActionResult Index(int id)
        {
            ViewBag.MestreId = id;
            return View(_mestreAreaAppService.GetAll());
        }


        public ActionResult Details(Guid id)
        {
            var mestre = _mestreAreaAppService.GetById(id);
            return mestre == null ? (ActionResult)HttpNotFound() : View(mestre);
        }

        public ActionResult Create(int id)
        {
            ViewBag.MestreId = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MestreAreaViewModel mestreAreaViewModel)
        {
            if (!ModelState.IsValid) return View(mestreAreaViewModel);
            _mestreAreaAppService.Add(mestreAreaViewModel);
            return RedirectToAction("Index", new { id = mestreAreaViewModel.MestreId });
        }

        public ActionResult Edit(Guid id)
        {
            var mestre = _mestreAreaAppService.GetById(id);
            return mestre == null ? (ActionResult)HttpNotFound() : View(mestre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MestreAreaViewModel mestreAreaViewModel)
        {
            if (!ModelState.IsValid) return View(mestreAreaViewModel);
            _mestreAreaAppService.Update(mestreAreaViewModel);
            return RedirectToAction("Index", new { id = mestreAreaViewModel.MestreId });
        }

        public ActionResult Delete(Guid id)
        {
            var mestreAreaViewModel = _mestreAreaAppService.GetById(id);
            ViewBag.MestreId = id;
            return mestreAreaViewModel == null ? (ActionResult)HttpNotFound() : View(mestreAreaViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _mestreAreaAppService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
