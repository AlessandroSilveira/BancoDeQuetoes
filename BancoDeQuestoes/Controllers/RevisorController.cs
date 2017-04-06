using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Controllers
{
    public class RevisorController : Controller
    {
        private IRevisorRepository RevisorRepository { get; set; }

        public RevisorController(IRevisorRepository revisorRepository)
        {
            RevisorRepository = revisorRepository;
        }

      
        public ActionResult Index()
        {
            return View(RevisorRepository.GetAll());
        }

        
        public ActionResult Details(int id)
        {
            var iNscrBqRevisor = RevisorRepository.GetById(id);
            if (iNscrBqRevisor == null)
            {
                return HttpNotFound();
            }
            return View(iNscrBqRevisor);
        }

       
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_REVISOR,DESC_NOME,DESC_CEP,DESC_ENDERECO,DESC_COMPLEMENTO,DESC_NUMERO,DESC_BAIRRO,DESC_CIDADE,DESC_ESTADO,DESC_FORMACAO,DESC_INSTITUICAO,DESC_FORMACAO_2,DESC_INSTITUICAO_2,DESC_FORMACAO_3,DESC_INSTITUICAO_3,DESC_CPF,DESC_EMAIL,DESC_EMAIL_2,DESC_DDD,DESC_TELEFONE,DESC_DDD_CEL,DESC_CELULAR,DESC_SENHA,DESC_DISCIPLINA,DESC_ATIVO")] INSCR_BQ_REVISOR iNSCR_BQ_REVISOR)
        {
            if (!ModelState.IsValid) return View(iNSCR_BQ_REVISOR);
            RevisorRepository.Add(iNSCR_BQ_REVISOR);
                
            return RedirectToAction("Index");
        }

        // GET: Revisor/Edit/5
        public ActionResult Edit(int id)
        {
            var iNscrBqRevisor = RevisorRepository.GetById(id);
            return iNscrBqRevisor == null ? (ActionResult) HttpNotFound() : View(iNscrBqRevisor);
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_REVISOR,DESC_NOME,DESC_CEP,DESC_ENDERECO,DESC_COMPLEMENTO,DESC_NUMERO,DESC_BAIRRO,DESC_CIDADE,DESC_ESTADO,DESC_FORMACAO,DESC_INSTITUICAO,DESC_FORMACAO_2,DESC_INSTITUICAO_2,DESC_FORMACAO_3,DESC_INSTITUICAO_3,DESC_CPF,DESC_EMAIL,DESC_EMAIL_2,DESC_DDD,DESC_TELEFONE,DESC_DDD_CEL,DESC_CELULAR,DESC_SENHA,DESC_DISCIPLINA,DESC_ATIVO")] INSCR_BQ_REVISOR iNSCR_BQ_REVISOR)
        {
            if (!ModelState.IsValid) return View(iNSCR_BQ_REVISOR);
            RevisorRepository.Update(iNSCR_BQ_REVISOR);
            return RedirectToAction("Index");
        }

       
        public ActionResult Delete(int id)
        {
            var iNscrBqRevisor = RevisorRepository.GetById(id);
            return iNscrBqRevisor == null ? (ActionResult) HttpNotFound() : View(iNscrBqRevisor);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var iNscrBqRevisor = RevisorRepository.GetById(id);
            RevisorRepository.Remove(iNscrBqRevisor);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                RevisorRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
