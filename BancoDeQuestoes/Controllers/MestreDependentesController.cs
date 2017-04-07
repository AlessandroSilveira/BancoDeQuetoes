using System;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Controllers
{
	public class MestreDependentesController : Controller
	{
		public MestreDependentesController(IMestreDependentesRepository mestreDependenteRepository, IMestreRepository mestreRepository)
		{
			MestreDependenteRepository = mestreDependenteRepository;
			MestreRepository = mestreRepository;
		}

		private IMestreDependentesRepository MestreDependenteRepository { get; }
		private IMestreRepository MestreRepository { get; }


		public ActionResult Index(int id)
		{
			ViewBag.DadosMestre = MestreRepository.GetById(id);
			return View(MestreDependenteRepository.GetAll());
		}

		public ActionResult Details(int? id)
		{
			if (id != null)
			{
				var mestreDependente = MestreDependenteRepository.GetById(Convert.ToInt16(id));
				return mestreDependente == null ? (ActionResult) HttpNotFound() : View(mestreDependente);
			}
			return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
		}

		public ActionResult Create(int id)
		{
			ViewBag.id = id;
			ViewBag.DadosMestre = MestreRepository.GetById(id);
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "IdMestreDependente,IDMestre,Nome,Documento,DataDeNascimento")] MestreDependente mestreDependente)
		{
			if (!ModelState.IsValid)
			{
				ViewBag.DadosMestre = MestreRepository.GetById(mestreDependente.IDMestre);
				return View(mestreDependente);
			}
			MestreDependenteRepository.Add(mestreDependente);
			ViewBag.DadosMestre = MestreRepository.GetById(mestreDependente.IDMestre);
			return RedirectToAction("Index", new { id = ViewBag.DadosMestre.ID_MESTRE });
		}

		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			var mestreDependente = MestreDependenteRepository.GetById(Convert.ToInt16(id));

			if (mestreDependente == null)
			{
				return HttpNotFound();
			}
			ViewBag.DadosMestre = MestreRepository.GetById(mestreDependente.IDMestre);
			return View(mestreDependente);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "IdMestreDependente,IDMestre,Nome,Documento,DataDeNascimento")] MestreDependente mestreDependente)
		{
			if (ModelState.IsValid)
			{
				MestreDependenteRepository.Update(mestreDependente);
				return RedirectToAction("Index", new { id = mestreDependente.IDMestre });
			}
			return View(mestreDependente);
		}

		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			var mestreDependente = MestreDependenteRepository.GetById(Convert.ToInt16(id));
			if (mestreDependente == null)
			{
				return HttpNotFound();
			}
			return View(mestreDependente);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			var mestreDependente = MestreDependenteRepository.GetById(Convert.ToInt16(id));
			MestreDependenteRepository.Remove(mestreDependente);
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				MestreDependenteRepository.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
