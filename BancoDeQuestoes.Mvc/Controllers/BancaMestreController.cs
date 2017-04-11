using System;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class BancaMestreController : Controller
    {
        public BancaMestreController(IBancaMestreRepository bancaMestreRepository)
        {
            BancaMestreRepository = bancaMestreRepository;
        }

        private IBancaMestreRepository BancaMestreRepository { get; set; }
       
        public ActionResult Index()
        {
            return View(BancaMestreRepository.GetAll());
        }
        
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var iNscrBqBanca = BancaMestreRepository.GetById(Convert.ToInt32(id));
            return iNscrBqBanca == null ? (ActionResult) HttpNotFound() : View(iNscrBqBanca);
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_BANCA,DESC_BANCA,DESC_STATUS,DESC_VALOR_PORCENTAGEM")] Banca banca)
        {
            if (!ModelState.IsValid) return View(banca);
            BancaMestreRepository.Add(banca);
            return RedirectToAction("Index");
        }
       
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var iNscrBqBanca = BancaMestreRepository.GetById(Convert.ToInt32(id));
            return iNscrBqBanca == null ? (ActionResult) HttpNotFound() : View(iNscrBqBanca);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_BANCA,DESC_BANCA,DESC_STATUS,DESC_VALOR_PORCENTAGEM")] Banca banca)
        {
            if (!ModelState.IsValid) return View(banca);
            BancaMestreRepository.Update(banca);
	        return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var iNscrBqBanca = BancaMestreRepository.GetById(Convert.ToInt32(id));

            return iNscrBqBanca == null ? (ActionResult) HttpNotFound() : View(iNscrBqBanca);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
	        var iNscrBqBanca = BancaMestreRepository.GetById(Convert.ToInt32(id));
			BancaMestreRepository.Remove(iNscrBqBanca);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                BancaMestreRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
