using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Controllers
{
    public class DisciplinaController : Controller
    {
        private IDisciplinaRepository DisciplinaRepository { get; set; }

        public DisciplinaController(IDisciplinaRepository disciplinaRepository)
        {
            DisciplinaRepository = disciplinaRepository;
        }

        // GET: Disciplina
        public ActionResult Index()
        {
            ViewBag.ListaDisciplinas = DisciplinaRepository.ListaArea();
            var iNscrBqTopico = DisciplinaRepository.List();
            return View(iNscrBqTopico.ToList());
        }

        // GET: Disciplina/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var iNscrBqTopico = DisciplinaRepository.Find(id);
            if (iNscrBqTopico == null)
            {
                return HttpNotFound();
            }
            return View(iNscrBqTopico);
        }

        // GET: Disciplina/Create
        public ActionResult Create()
        {
            ViewBag.ID_CARGO = new SelectList(DisciplinaRepository.Cargo(), "ID_CARGO_CBO", "DESC_CARGO");
            ViewBag.ID_DISCIPLINA = new SelectList(DisciplinaRepository.Area(), "ID_DISCIPLINA", "DESC_DISCIPLINA");
            return View();
        }

        // POST: Disciplina/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
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
                DisciplinaRepository.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.ID_CARGO = new SelectList(DisciplinaRepository.Cargo(), "ID_CARGO_CBO", "DESC_CARGO",
                iNscrBqTopico.ID_CARGO);
            ViewBag.ID_DISCIPLINA = new SelectList(DisciplinaRepository.Area(), "ID_DISCIPLINA", "DESC_DISCIPLINA",
                iNscrBqTopico.ID_DISCIPLINA);
            return View(iNscrBqTopico);
        }

        // GET: Disciplina/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var iNscrBqTopico = DisciplinaRepository.Find(id);
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

        // POST: Disciplina/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
        [Bind(
            Include = "ID_TOPICO,ID_DISCIPLINA,ID_CARGO,DESC_TITULO,DESC_TOPICO,DESC_BIBLIOGRAFIA,DESC_ATIVO,DESC_NIVEL"
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
            DisciplinaRepository.Entry(iNscrBqTopico).State = EntityState.Modified;
            DisciplinaRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Disciplina/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                var iNscrBqTopico = DisciplinaRepository.Find(id);
                return iNscrBqTopico == null ? (ActionResult) HttpNotFound() : View(iNscrBqTopico);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        // POST: Disciplina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var iNscrBqTopico = DisciplinaRepository.Find(id);
            DisciplinaRepository.Remove(iNscrBqTopico);
            DisciplinaRepository.SaveChanges();
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
    }
}