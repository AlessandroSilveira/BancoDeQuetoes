using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Controllers
{
    public class ProjetoController : Controller
    {
        private IProjetoRepository ProjetoRepository { get; set; }

        

        public ProjetoController(IProjetoRepository projetoRepository)
        {
            ProjetoRepository = projetoRepository;
        }

        // GET: Projeto
        public ActionResult Index()
        {
            return View(ProjetoRepository.List());
        }

        // GET: Projeto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INSCR_BQ_PROJETO iNSCR_BQ_PROJETO = ProjetoRepository.Find(id);
            if (iNSCR_BQ_PROJETO == null)
            {
                return HttpNotFound();
            }
            return View(iNSCR_BQ_PROJETO);
        }

        // GET: Projeto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projeto/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PROJETO,COD_PROJETO,DESC_PROJETO,DESC_ATIVO")] INSCR_BQ_PROJETO iNSCR_BQ_PROJETO)
        {
            if (ModelState.IsValid)
            {
                ProjetoRepository.Add(iNSCR_BQ_PROJETO);
                ProjetoRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iNSCR_BQ_PROJETO);
        }

        // GET: Projeto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INSCR_BQ_PROJETO iNSCR_BQ_PROJETO = ProjetoRepository.Find(id);
            if (iNSCR_BQ_PROJETO == null)
            {
                return HttpNotFound();
            }
           
            return View(iNSCR_BQ_PROJETO);
        }

        // POST: Projeto/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PROJETO,COD_PROJETO,DESC_PROJETO,DESC_ATIVO")] INSCR_BQ_PROJETO iNSCR_BQ_PROJETO)
        {
            if (!ModelState.IsValid) return View(iNSCR_BQ_PROJETO);

            ProjetoRepository.Entry(iNSCR_BQ_PROJETO).State = EntityState.Modified;
            ProjetoRepository.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Projeto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INSCR_BQ_PROJETO iNSCR_BQ_PROJETO = ProjetoRepository.Find(id);
            if (iNSCR_BQ_PROJETO == null)
            {
                return HttpNotFound();
            }
            return View(iNSCR_BQ_PROJETO);
        }

        // POST: Projeto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            INSCR_BQ_PROJETO iNSCR_BQ_PROJETO = ProjetoRepository.Find(id);
            ProjetoRepository.Remove(iNSCR_BQ_PROJETO);
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
