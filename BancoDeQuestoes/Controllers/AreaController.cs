using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Controllers
{
    public class AreaController : Controller
    {
        private IAreaRepository AreaRepository { get; set; }

        public AreaController(IAreaRepository areaRepository)
        {
            AreaRepository = areaRepository;
        }

        // GET: Disciplina
        public ActionResult Index()
        {

            return View(AreaRepository.List());
        }

        // GET: Disciplina/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            var iNscrBqDisciplina = AreaRepository.Find(id);
            return iNscrBqDisciplina == null ? (ActionResult)HttpNotFound() : View(iNscrBqDisciplina);
        }

        // GET: Disciplina/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disciplina/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_DISCIPLINA,DESC_DISCIPLINA,TIPO_CONH_ESPEC,DESC_ATIVO")] INSCR_BQ_DISCIPLINA iNSCR_BQ_DISCIPLINA)
        {
            if (!ModelState.IsValid) return View(iNSCR_BQ_DISCIPLINA);
            AreaRepository.Add(iNSCR_BQ_DISCIPLINA);
            AreaRepository.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Disciplina/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var iNscrBqDisciplina = AreaRepository.Find(id);
            return iNscrBqDisciplina == null ? (ActionResult)HttpNotFound() : View(iNscrBqDisciplina);
        }

        // POST: Disciplina/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_DISCIPLINA,DESC_DISCIPLINA,TIPO_CONH_ESPEC,DESC_ATIVO")] INSCR_BQ_DISCIPLINA iNSCR_BQ_DISCIPLINA)
        {
            if (!ModelState.IsValid) return View(iNSCR_BQ_DISCIPLINA);
            AreaRepository.Entry(iNSCR_BQ_DISCIPLINA).State = EntityState.Modified;
            AreaRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Disciplina/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var iNscrBqDisciplina = AreaRepository.Find(id);
            if (iNscrBqDisciplina == null)
            {
                return HttpNotFound();
            }
            return View(iNscrBqDisciplina);
        }

        // POST: Disciplina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var iNscrBqDisciplina = AreaRepository.Find(id);

            AreaRepository.Remove(iNscrBqDisciplina);

            //db.INSCR_BQ_DISCIPLINA.Remove(iNscrBqDisciplina);
            AreaRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                AreaRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
