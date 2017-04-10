using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Controllers
{
    public class DisciplinaController : Controller
    {
        private IDisciplinaRepository DisciplinaRepository { get; set; }

        public DisciplinaController(IDisciplinaRepository disciplinaRepository)
        {
            DisciplinaRepository = disciplinaRepository;
        }
       
        public ActionResult Index(IEnumerable<INSCR_BQ_TOPICO> iNscrBqTopico)
        {
	        ViewBag.ListaDisciplinas = DisciplinaRepository.Area();
	        if (iNscrBqTopico == null)
	        {
				iNscrBqTopico = DisciplinaRepository.GetAll();
			}
            return View(iNscrBqTopico.ToList());
        }
		
		public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

	        var iNscrBqTopico = DisciplinaRepository.GetById(Convert.ToInt32(id));

			if (iNscrBqTopico == null)
            {
                return HttpNotFound();
            }
            return View(iNscrBqTopico);
        }
      
        public ActionResult Create()
        {
            ViewBag.ID_CARGO = new SelectList(DisciplinaRepository.Cargo(), "ID_CARGO_CBO", "DESC_CARGO");
            ViewBag.ID_DISCIPLINA = new SelectList(DisciplinaRepository.Area(), "ID_DISCIPLINA", "DESC_DISCIPLINA");
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
        [Bind(
            Include = "ID_TOPICO,ID_DISCIPLINA,ID_CARGO,DESC_TITULO,DESC_TOPICO,DESC_BIBLIOGRAFIA,DESC_ATIVO,DESC_NIVEL"
        )] INSCR_BQ_TOPICO iNscrBqTopico)
        {
            if (ModelState.IsValid)
            {
                DisciplinaRepository.Add(iNscrBqTopico);
                return RedirectToAction("Index");
            }

            ViewBag.ID_CARGO = new SelectList(DisciplinaRepository.Cargo(), "ID_CARGO_CBO", "DESC_CARGO",
                iNscrBqTopico.ID_CARGO);
            ViewBag.ID_DISCIPLINA = new SelectList(DisciplinaRepository.Area(), "ID_DISCIPLINA", "DESC_DISCIPLINA",
                iNscrBqTopico.ID_DISCIPLINA);
            return View(iNscrBqTopico);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
	        var iNscrBqTopico = DisciplinaRepository.GetById(Convert.ToInt32(id));

			if (iNscrBqTopico == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CARGO = new SelectList(DisciplinaRepository.Cargo(), "ID_CARGO_CBO", "DESC_CARGO",
                iNscrBqTopico.ID_CARGO);
            ViewBag.ID_DISCIPLINA = new SelectList(DisciplinaRepository.Area(), "ID_DISCIPLINA", "DESC_DISCIPLINA",
                iNscrBqTopico.ID_DISCIPLINA);
            return View(iNscrBqTopico);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
        [Bind(Include = "ID_TOPICO,ID_DISCIPLINA,ID_CARGO,DESC_TITULO,DESC_TOPICO,DESC_BIBLIOGRAFIA,DESC_ATIVO,DESC_NIVEL"
        )] INSCR_BQ_TOPICO iNscrBqTopico)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ID_CARGO = new SelectList(DisciplinaRepository.Cargo(), "ID_CARGO_CBO", "DESC_CARGO",
                    iNscrBqTopico.ID_CARGO);
                ViewBag.ID_DISCIPLINA = new SelectList(DisciplinaRepository.Area(), "ID_DISCIPLINA", "DESC_DISCIPLINA",
                    iNscrBqTopico.ID_DISCIPLINA);
                return View(iNscrBqTopico);
            }
            DisciplinaRepository.Update(iNscrBqTopico);
           
            return RedirectToAction("Index");
        }
       
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
	            var iNscrBqTopico = DisciplinaRepository.GetById(Convert.ToInt32(id));
				return iNscrBqTopico == null ? (ActionResult) HttpNotFound() : View(iNscrBqTopico);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
	        var iNscrBqTopico = DisciplinaRepository.GetById(Convert.ToInt32(id));
            DisciplinaRepository.Remove(iNscrBqTopico);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisciplinaRepository.Dispose();
            }
            base.Dispose(disposing);
        }

		[HttpPost]
	    public ActionResult Search(INSCR_BQ_TOPICO form)
	    {
			ViewBag.ListaDisciplinas = DisciplinaRepository.Area();
			var iNscrBqTopico = DisciplinaRepository.ResultadoPesquisaDisciplina(form);
		    return View(iNscrBqTopico);
	    }

	}
}