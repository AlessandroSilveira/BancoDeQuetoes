using System.Linq;
using System.Web.Mvc;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class MestreController : Controller
    {
        public MestreController(IMestreRepository mestreRepository, IBancaMestreRepository bancaMestreRepository, IDisciplinaRepository disciplinaRepository)
        {
            MestreRepository = mestreRepository;
            _bancaMestreRepository = bancaMestreRepository;
            this._disciplinaRepository = disciplinaRepository;
        }
        private IMestreRepository MestreRepository { get; set; }
        private readonly IBancaMestreRepository _bancaMestreRepository;
        private IDisciplinaRepository _disciplinaRepository;
       
        public ActionResult Index()
        {
           var iNscrBqMestre = MestreRepository.Include();
            return View(iNscrBqMestre.ToList());
        }
       
        public ActionResult Details(int id)
        {
            var iNscrBqMestre = MestreRepository.GetById(id);
            return iNscrBqMestre == null ? (ActionResult) HttpNotFound() : View(iNscrBqMestre);
        }
       
        public ActionResult Create()
        {
            ViewBag.ID_BANCA = new SelectList(_bancaMestreRepository.GetAll(), "ID_BANCA", "DESC_BANCA");
            ViewBag.DESC_DISCIPLINA = new SelectList(_disciplinaRepository.GetAll(), "ID_TOPICO", "DESC_TITULO");
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_MESTRE,ID_BANCA,DESC_NOME,DESC_CEP,DESC_ENDERECO,DESC_COMPLEMENTO,DESC_NUMERO,DESC_BAIRRO,DESC_CIDADE,DESC_ESTADO,DESC_FORMACAO,GRAU_FORMACAO,DESC_INSTITUICAO,DESC_FORMACAO_2,GRAU_FORMACAO_2,DESC_INSTITUICAO_2,DESC_FORMACAO_3,GRAU_FORMACAO_3,DESC_INSTITUICAO_3,DESC_FORMACAO_4,GRAU_FORMACAO_4,DESC_INSTITUICAO_4,DESC_CPF,DESC_EMAIL,DESC_EMAIL_2,DESC_DDD,DESC_TELEFONE,DESC_DDD_CEL,DESC_CELULAR,DESC_SENHA,DESC_DISCIPLINA,DESC_ATIVO,DESC_BANCO,DESC_AGENCIA,DESC_TIPO_CONTA,DESC_CONTA,DESC_FILHOS,DESC_PIS,DESC_NOME_DEPENDENTE1,DESC_DOCUMENTO_DEPENDENTE1,DESC_DATA_NASCIMENTO_DEPENDENTE1,DESC_NOME_DEPENDENTE2,DESC_DOCUMENTO_DEPENDENTE2,DESC_DATA_NASCIMENTO_DEPENDENTE2,DESC_NOME_DEPENDENTE3,DESC_DOCUMENTO_DEPENDENTE3,DESC_DATA_NASCIMENTO_DEPENDENTE3,CURRICULO,DIPLOMA,DESC_ACEITE,ENTREGOU_COPIA_DIPLOMA_GRADUACAO,DIPLOMA_GRADUACAO_AUTENTICADO,NUMERO_COPIAS_DIPLOMA_AUTENTICADO,ENTREGOU_COPIA_DIPLOMA_POSGRADUACAO,DIPLOMA_POSGRADUACAO_AUTENTICADO,NUMERO_COPIAS_DIPLOMA_POSGRADUACAO_AUTENTICADO,ENTREGOU_COPIA_DIPLOMA_MESTRADO,DIPLOMA_MESTRADO_AUTENTICADO,NUMERO_COPIAS_DIPLOMA_MESTRADO_AUTENTICADO,ENTREGOU_COPIA_DIPLOMA_DOUTORADO,DIPLOMA_DOUTORADO_AUTENTICADO,NUMERO_COPIAS_DIPLOMA_DOUTORADO_AUTENTICADO,MINICURRICULO")] INSCR_BQ_MESTRE iNSCR_BQ_MESTRE)
        {
            if (ModelState.IsValid)
            {
                MestreRepository.Add(iNSCR_BQ_MESTRE);
                return RedirectToAction("Index");
            }

            ViewBag.ID_BANCA = new SelectList(_bancaMestreRepository.GetAll(), "ID_BANCA", "DESC_BANCA", iNSCR_BQ_MESTRE.ID_BANCA);
            return View(iNSCR_BQ_MESTRE);
        }
		
        public ActionResult Edit(int id)
        {
            var iNscrBqMestre = MestreRepository.GetById(id);
            if (iNscrBqMestre == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_BANCA = new SelectList(_bancaMestreRepository.GetAll(), "ID_BANCA", "DESC_BANCA", iNscrBqMestre.ID_BANCA);
            return View(iNscrBqMestre);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_MESTRE,ID_BANCA,DESC_NOME,DESC_CEP,DESC_ENDERECO,DESC_COMPLEMENTO,DESC_NUMERO,DESC_BAIRRO,DESC_CIDADE,DESC_ESTADO,DESC_FORMACAO,GRAU_FORMACAO,DESC_INSTITUICAO,DESC_FORMACAO_2,GRAU_FORMACAO_2,DESC_INSTITUICAO_2,DESC_FORMACAO_3,GRAU_FORMACAO_3,DESC_INSTITUICAO_3,DESC_FORMACAO_4,GRAU_FORMACAO_4,DESC_INSTITUICAO_4,DESC_CPF,DESC_EMAIL,DESC_EMAIL_2,DESC_DDD,DESC_TELEFONE,DESC_DDD_CEL,DESC_CELULAR,DESC_SENHA,DESC_DISCIPLINA,DESC_ATIVO,DESC_BANCO,DESC_AGENCIA,DESC_TIPO_CONTA,DESC_CONTA,DESC_FILHOS,DESC_PIS,DESC_NOME_DEPENDENTE1,DESC_DOCUMENTO_DEPENDENTE1,DESC_DATA_NASCIMENTO_DEPENDENTE1,DESC_NOME_DEPENDENTE2,DESC_DOCUMENTO_DEPENDENTE2,DESC_DATA_NASCIMENTO_DEPENDENTE2,DESC_NOME_DEPENDENTE3,DESC_DOCUMENTO_DEPENDENTE3,DESC_DATA_NASCIMENTO_DEPENDENTE3,CURRICULO,DIPLOMA,DESC_ACEITE,ENTREGOU_COPIA_DIPLOMA_GRADUACAO,DIPLOMA_GRADUACAO_AUTENTICADO,NUMERO_COPIAS_DIPLOMA_AUTENTICADO,ENTREGOU_COPIA_DIPLOMA_POSGRADUACAO,DIPLOMA_POSGRADUACAO_AUTENTICADO,NUMERO_COPIAS_DIPLOMA_POSGRADUACAO_AUTENTICADO,ENTREGOU_COPIA_DIPLOMA_MESTRADO,DIPLOMA_MESTRADO_AUTENTICADO,NUMERO_COPIAS_DIPLOMA_MESTRADO_AUTENTICADO,ENTREGOU_COPIA_DIPLOMA_DOUTORADO,DIPLOMA_DOUTORADO_AUTENTICADO,NUMERO_COPIAS_DIPLOMA_DOUTORADO_AUTENTICADO,MINICURRICULO")] INSCR_BQ_MESTRE iNSCR_BQ_MESTRE)
        {
            if (ModelState.IsValid)
            {
                MestreRepository.Update(iNSCR_BQ_MESTRE);
                return RedirectToAction("Index");
            }
            ViewBag.ID_BANCA = new SelectList(_bancaMestreRepository.GetAll(), "ID_BANCA", "DESC_BANCA", iNSCR_BQ_MESTRE.ID_BANCA);
            return View(iNSCR_BQ_MESTRE);
        }

       public ActionResult Delete(int id)
        {
            var iNscrBqMestre = MestreRepository.GetById(id);
            if (iNscrBqMestre == null)
            {
                return HttpNotFound();
            }
            return View(iNscrBqMestre);
        }

		[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var iNscrBqMestre = MestreRepository.GetById(id);
            MestreRepository.Remove(iNscrBqMestre);
            return RedirectToAction("Index");
        }


		[HttpPost]
		public ActionResult Search(INSCR_BQ_MESTRE form)
		{
			
			var iNscrBqTopico = MestreRepository.ResultadoPesquisaMestre(form);
			return View(iNscrBqTopico);
		}


		protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                MestreRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
