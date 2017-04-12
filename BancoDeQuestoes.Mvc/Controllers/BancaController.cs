using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Infra.Data.Context;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class BancaController : Controller
    {
	    private readonly IBancaAppService _bancaAppService;

	    public BancaController(IBancaAppService bancaAppService)
	    {
		    _bancaAppService = bancaAppService;
	    }

	    // GET: Banca
        public ActionResult Index()
        {
			var bancaViewModel =
			   Mapper.Map<IEnumerable<Banca>, IEnumerable<BancaViewModel>>(_bancaAppService.GetAll());
			return View(bancaViewModel);
        }

        // GET: Banca/Details/5
        public ActionResult Details(int id)
        {
			var banca = _bancaAppService.GetById(Convert.ToInt32(id));
			var bancaViewModel = Mapper.Map<Banca, BancaViewModel>(banca);
	        return bancaViewModel == null ? (ActionResult) HttpNotFound() : View(bancaViewModel);
        }

        // GET: Banca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Banca/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BancaViewModel bancaViewModel)
        {
	        if (!ModelState.IsValid) return View(bancaViewModel);
	        var banca = Mapper.Map<BancaViewModel, Banca>(bancaViewModel);
	        _bancaAppService.Add(banca);

	        return RedirectToAction("Index");
        }

        // GET: Banca/Edit/5
        public ActionResult Edit(int id)
        {

			var banca = _bancaAppService.GetById(Convert.ToInt32(id));
			var bancaViewModel = Mapper.Map<Banca, BancaViewModel>(banca);
			return View(bancaViewModel);
		}

        // POST: Banca/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BancaViewModel bancaViewModel)
        {
			if (!ModelState.IsValid) return View(bancaViewModel);
			var bancaDomain = Mapper.Map<BancaViewModel, Banca>(bancaViewModel);
			_bancaAppService.Update(bancaDomain);

			return RedirectToAction("Index");
		}

        // GET: Banca/Delete/5
        public ActionResult Delete(int id)
        {
			var banca = _bancaAppService.GetById(id);
			var bancaViewModel = Mapper.Map<Banca, BancaViewModel>(banca);

			return View(bancaViewModel);
		}

        // POST: Banca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			var banca = _bancaAppService.GetById(id);
			_bancaAppService.Remove(banca);

			return RedirectToAction("Index");
		}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
				_bancaAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
