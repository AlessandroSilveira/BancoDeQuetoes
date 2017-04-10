using System;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class ProjetoController : Controller
    {
        private IProjetoRepository ProjetoRepository { get; }
		
        public ProjetoController(IProjetoRepository projetoRepository)
        {
            ProjetoRepository = projetoRepository;
        }
      
        public ActionResult Index()
        {
            return View(ProjetoRepository.GetAll());
        }
       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var iNscrBqProjeto = ProjetoRepository.GetById(Convert.ToInt32(id));
            if (iNscrBqProjeto == null)
            {
                return HttpNotFound();
            }
            return View(iNscrBqProjeto);
        }
        
        public ActionResult Create()
        {
            return View();
        }
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjetoId,CodigoProjeto,NomeProjeto,Ativo")] Projeto iNscrBqProjeto)
        {
            if (!ModelState.IsValid) return View(iNscrBqProjeto);
            ProjetoRepository.Add(iNscrBqProjeto);
            return RedirectToAction("Index");
        }
		
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var iNscrBqProjeto = ProjetoRepository.GetById(Convert.ToInt32(id));
            return iNscrBqProjeto == null ? (ActionResult) HttpNotFound() : View(iNscrBqProjeto);
        }

		[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjetoId,CodigoProjeto,NomeProjeto,Ativo")] Projeto iNscrBqProjeto)
        {
            if (!ModelState.IsValid) return View(iNscrBqProjeto);
			ProjetoRepository.Update(iNscrBqProjeto);
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                var iNscrBqProjeto = ProjetoRepository.GetById(Convert.ToInt32(id));
                return iNscrBqProjeto == null ? (ActionResult) HttpNotFound() : View(iNscrBqProjeto);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
		
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var iNscrBqProjeto = ProjetoRepository.GetById(Convert.ToInt32(id));
			ProjetoRepository.Remove(iNscrBqProjeto);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ProjetoRepository.Dispose();
               
            }
            base.Dispose(disposing);
        }
    }
}
