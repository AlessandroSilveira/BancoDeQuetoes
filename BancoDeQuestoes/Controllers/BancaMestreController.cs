using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Controllers
{
    public class BancaMestreController : Controller
    {
        public BancaMestreController(IBancaMestreRepository bancaMestreRepository)
        {
            BancaMestreRepository = bancaMestreRepository;
        }

        private IBancaMestreRepository BancaMestreRepository { get; set; }

        // GET: BancaMestre
        public ActionResult Index()
        {
            return View(BancaMestreRepository.List());
        }

        // GET: BancaMestre/Details/5
        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                var iNscrBqBanca = BancaMestreRepository.Find(id);
                return iNscrBqBanca == null ? (ActionResult) HttpNotFound() : View(iNscrBqBanca);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        // GET: BancaMestre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BancaMestre/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_BANCA,DESC_BANCA,DESC_STATUS,DESC_VALOR_PORCENTAGEM")] INSCR_BQ_BANCA iNSCR_BQ_BANCA)
        {
            if (!ModelState.IsValid) return View(iNSCR_BQ_BANCA);
            BancaMestreRepository.Add(iNSCR_BQ_BANCA);
            BancaMestreRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: BancaMestre/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                var iNscrBqBanca = BancaMestreRepository.Find(id);
                if (iNscrBqBanca == null)
                {
                    return HttpNotFound();
                }
                return View(iNscrBqBanca);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        // POST: BancaMestre/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_BANCA,DESC_BANCA,DESC_STATUS,DESC_VALOR_PORCENTAGEM")] INSCR_BQ_BANCA iNSCR_BQ_BANCA)
        {
            if (ModelState.IsValid)
            {
                BancaMestreRepository.Entry(iNSCR_BQ_BANCA).State = EntityState.Modified;
                BancaMestreRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iNSCR_BQ_BANCA);
        }

        // GET: BancaMestre/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var iNscrBqBanca = BancaMestreRepository.Find(id);
            if (iNscrBqBanca == null)
            {
                return HttpNotFound();
            }
            return View(iNscrBqBanca);
        }

        // POST: BancaMestre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var iNscrBqBanca = BancaMestreRepository.Find(id);
            BancaMestreRepository.Remove(iNscrBqBanca);
            BancaMestreRepository.SaveChanges();
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
