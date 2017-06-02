using System;
using System.Linq;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class MestreController : Controller
    {
        private readonly IMestreAppService _mestreAppService;
        private readonly IBancaAppService _bancaAppService;
        private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;

      
        public MestreController(IMestreAppService mestreAppService, IBancaAppService bancaAppService, ITopicoAtribuidoAppService topicoAtribuidoAppService)
        {
            _mestreAppService = mestreAppService;
            _bancaAppService = bancaAppService;
            _topicoAtribuidoAppService = topicoAtribuidoAppService;
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(_mestreAppService.GetAll());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Details(Guid id)
        {
            var mestre = _mestreAppService.GetById(id);
            return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.BancaId = new SelectList(_bancaAppService.GetAll(), "BancaId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(MestreViewModel mestreViewModel)
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

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid id)
        {
            var mestre = _mestreAppService.GetById(id);
            return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MestreViewModel mestreViewModel)
        {
            if (!ModelState.IsValid) return View(mestreViewModel);
            _mestreAppService.Update(mestreViewModel);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            var mestre = _mestreAppService.GetById(id);
            return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _mestreAppService.Remove(id);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Mestre")]
        public ActionResult ListaQuestoesAtribuidas()
        {
           
            var dadosMestre = _mestreAppService.Search(a => a.Email.Equals(User.Identity.Name)).FirstOrDefault();

            if (dadosMestre==null)
            {
                return RedirectToAction("Login", "Account");
            }

            var listaQuestoesAtribuidasMestre = _topicoAtribuidoAppService.Search(a => a.MestreId.Equals(dadosMestre.MestreId));
            return View(listaQuestoesAtribuidasMestre);
        }

    }
}
