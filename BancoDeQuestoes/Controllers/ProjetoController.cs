﻿using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Controllers
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
            return View(ProjetoRepository.List());
        }
       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var iNscrBqProjeto = ProjetoRepository.Find(id);
            if (ProjetoRepository.Find(id) == null)
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
        public ActionResult Create([Bind(Include = "ID_PROJETO,COD_PROJETO,DESC_PROJETO,DESC_ATIVO")] INSCR_BQ_PROJETO iNscrBqProjeto)
        {
            if (ModelState.IsValid)
            {
                ProjetoRepository.Add(iNscrBqProjeto);
                ProjetoRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iNscrBqProjeto);
        }
		
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var iNscrBqProjeto = ProjetoRepository.Find(id);
            if (iNscrBqProjeto == null)
            {
                return HttpNotFound();
            }
           
            return View(iNscrBqProjeto);
        }

		[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PROJETO,COD_PROJETO,DESC_PROJETO,DESC_ATIVO")] INSCR_BQ_PROJETO iNscrBqProjeto)
        {
            if (!ModelState.IsValid) return View(iNscrBqProjeto);
           
			ProjetoRepository.Update(iNscrBqProjeto);
            ProjetoRepository.SaveChanges();

            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var iNscrBqProjeto = ProjetoRepository.Find(id);
            if (iNscrBqProjeto == null)
            {
                return HttpNotFound();
            }
            return View(iNscrBqProjeto);
        }
		
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var iNscrBqProjeto = ProjetoRepository.Find(id);
            ProjetoRepository.Remove(iNscrBqProjeto);
            ProjetoRepository.SaveChanges();
            
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
