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
	public class MestreFormacaoController : Controller
    {
	    public MestreFormacaoController(IMestreFormacaoRepository mestreFormacaoRepository, IMestreRepository mestreRepository)
	    {
		    MestreFormacaoRepository = mestreFormacaoRepository;
		    MestreRepository = mestreRepository;
	    }

	    private IMestreFormacaoRepository MestreFormacaoRepository { get;  }
		private IMestreRepository MestreRepository { get; }

        public ActionResult Index(int id)
        {
	        ViewBag.DadosMestre = MestreRepository.GetById(id);
            var iNscrBqMestreFormacao = MestreFormacaoRepository.Include();
            return View(iNscrBqMestreFormacao.ToList());
        }
       
        public ActionResult Details(int? id)
        {
	        if (id != null)
	        {
		        var iNscrBqMestreFormacao = MestreFormacaoRepository.GetById(Convert.ToInt32(id));
		        return iNscrBqMestreFormacao == null ? (ActionResult) HttpNotFound() : View(iNscrBqMestreFormacao);
	        }
	        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
		
        public ActionResult Create(int id)
        {
	        ViewBag.id = id;
			ViewBag.DadosMestre = MestreRepository.GetById(id);
			ViewBag.DESC_TIPO_FORMACAO = new SelectList(ListaTipoGraduacao(), "Key", "Value");
			return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_MESTRE_FORMACAO,ID_MESTRE,DESC_TIPO_FORMACAO,DESC_CURSO,DESC_INSTITUICAO,DESC_COPIA_DIPLOMA,DESC_DIPLOMA_AUTENTICADO,DESC_NUMERO_COPIAS,ID_MESTRE")] INSCR_BQ_MESTRE_FORMACAO iNSCR_BQ_MESTRE_FORMACAO)
        {
            if (ModelState.IsValid)
            {
				ViewBag.DadosMestre = MestreRepository.GetById(iNSCR_BQ_MESTRE_FORMACAO.ID_MESTRE);
				ViewBag.DESC_TIPO_FORMACAO = new SelectList(ListaTipoGraduacao(), "Key", "Value");
				MestreFormacaoRepository.Add(iNSCR_BQ_MESTRE_FORMACAO);
                return RedirectToAction("Index", new {@id= iNSCR_BQ_MESTRE_FORMACAO.ID_MESTRE });
            }
			ViewBag.DadosMestre = MestreRepository.GetById(iNSCR_BQ_MESTRE_FORMACAO.ID_MESTRE);
			ViewBag.DESC_TIPO_FORMACAO = new SelectList(ListaTipoGraduacao(), "Key", "Value");
			return View(iNSCR_BQ_MESTRE_FORMACAO);
        }
        
        public ActionResult Edit(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var iNscrBqMestreFormacao = MestreFormacaoRepository.GetById(Convert.ToInt32(id));
				
	        if (iNscrBqMestreFormacao == null) return HttpNotFound();
			ViewBag.DESC_TIPO_FORMACAO = new SelectList(ListaTipoGraduacao(), "Key", "Value");
			ViewBag.DadosMestre = MestreRepository.GetById(iNscrBqMestreFormacao.ID_MESTRE);
	        return View(iNscrBqMestreFormacao);
        }
		
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_MESTRE_FORMACAO,ID_MESTRE,DESC_TIPO_FORMACAO,DESC_CURSO,DESC_INSTITUICAO,DESC_COPIA_DIPLOMA,DESC_DIPLOMA_AUTENTICADO,DESC_NUMERO_COPIAS")] INSCR_BQ_MESTRE_FORMACAO iNSCR_BQ_MESTRE_FORMACAO)
        {
            if (ModelState.IsValid)
            {
				ViewBag.DESC_TIPO_FORMACAO = new SelectList(ListaTipoGraduacao(), "Key", "Value");
				MestreFormacaoRepository.Update(iNSCR_BQ_MESTRE_FORMACAO);
                return RedirectToAction("Index",new {@id= iNSCR_BQ_MESTRE_FORMACAO.ID_MESTRE});
            }
			ViewBag.DESC_TIPO_FORMACAO = new SelectList(ListaTipoGraduacao(), "Key", "Value");
			return View(iNSCR_BQ_MESTRE_FORMACAO);
        }

	    private Dictionary<string,string> ListaTipoGraduacao()
	    {
		    Dictionary<string, string> lista = new Dictionary<string, string>();
			lista.Add("", "Selecione");
			lista.Add("Graduação","Graduação");
			lista.Add("Pós-Graduação", "Pós-Graduação");
			lista.Add("Mestrado", "Mestrado");
			lista.Add("Doutorado", "Doutorado");
		    return lista;
	    }

	    public ActionResult Delete(int? id)
        {
	        if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
	        var iNscrBqMestreFormacao = MestreFormacaoRepository.GetById(Convert.ToInt32(id));
	        return iNscrBqMestreFormacao == null ? (ActionResult) HttpNotFound() : View(iNscrBqMestreFormacao);
        }
		
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
	        var iNscrBqMestreFormacao = MestreFormacaoRepository.GetById(Convert.ToInt32(id));
            MestreFormacaoRepository.Remove(iNscrBqMestreFormacao);
            return RedirectToAction("Index",new {@id= iNscrBqMestreFormacao.ID_MESTRE});
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                MestreFormacaoRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
