using System;
using System.Linq;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class MestreController : Controller
    {
        private readonly IMestreAppService _mestreAppService;
        private readonly IBancaAppService _bancaAppService;
        private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;
        private readonly IConviteMestreAppService _conviteMestreAppService;
        private readonly IQuestaoAppService _questaoAppService;
	    private readonly IRespostaAppService _respostaAppService;

        public MestreController(IMestreAppService mestreAppService, IBancaAppService bancaAppService,
            ITopicoAtribuidoAppService topicoAtribuidoAppService, IConviteMestreAppService conviteMestreAppService,
            IQuestaoAppService questaoAppService, IRespostaAppService respostaAppService)
        {
            _mestreAppService = mestreAppService;
            _bancaAppService = bancaAppService;
            _topicoAtribuidoAppService = topicoAtribuidoAppService;
            _conviteMestreAppService = conviteMestreAppService;
            _questaoAppService = questaoAppService;
	        _respostaAppService = respostaAppService;
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(_mestreAppService.GetAll());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Details(Guid id)
        {
            var mestre = _mestreAppService.GetById(id);
            return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.BancaId = new SelectList(_bancaAppService.GetAll(), "BancaId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(MestreViewModel mestreViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.BancaId = new SelectList(_bancaAppService.GetAll(), "BancaId", "Nome");
                return View(mestreViewModel);
            }
            _mestreAppService.Add(mestreViewModel);
            ViewBag.BancaId = new SelectList(_bancaAppService.GetAll(), "BancaId", "Nome");
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid id)
        {
            var mestre = _mestreAppService.GetById(id);
            return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MestreViewModel mestreViewModel)
        {
            if (!ModelState.IsValid) return View(mestreViewModel);
            _mestreAppService.Update(mestreViewModel);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            var mestre = _mestreAppService.GetById(id);
            return mestre == null ? (ActionResult) HttpNotFound() : View(mestre);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _mestreAppService.Remove(id);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Mestre")]
        public ActionResult ListaQuestoesAtribuidas()
        {
            var dadosMestre = _mestreAppService.Search(a => a.Email.Equals(User.Identity.Name)).FirstOrDefault();

            if (dadosMestre == null)
                return RedirectToAction("Login", "Account");

            var listaQuestoesAtribuidasMestre =
                _topicoAtribuidoAppService.Search(a => a.MestreId.Equals(dadosMestre.MestreId));
            return View(listaQuestoesAtribuidasMestre);
        }

        [Authorize(Roles = "Mestre")]
        public ActionResult ListaConvites()
        {
            var dadosMestre = _mestreAppService.Search(a => a.Email.Equals(User.Identity.Name)).FirstOrDefault();

            if (dadosMestre == null)
                return RedirectToAction("Login", "Account");

            var listaConvites = _conviteMestreAppService.Search(a => a.MestreId.Equals(dadosMestre.MestreId));

            return View(listaConvites);
        }


        [Authorize(Roles = "Mestre")]
        public ActionResult DetalhesConvite(Guid id)
        {
            var dadosMestre = _mestreAppService.Search(a => a.Email.Equals(User.Identity.Name)).FirstOrDefault();

            if (dadosMestre == null)
                return RedirectToAction("Login", "Account");
            var dadosConvite = _conviteMestreAppService.GetById(id);

            ViewBag.Convite = _conviteMestreAppService.GetById(dadosConvite.ConviteMestreId);
            ViewBag.ListaQuestoes =
                _questaoAppService.Search(a => a.TopicoAtribuidoId.Equals(dadosConvite.TopicoAtribuidoId));

            ViewBag.TipoPagamento = new SelectList(ListaTipoPagamento.TipoPagamento(), "Key", "Value");

            return View(dadosConvite);
        }

        [Authorize(Roles = "Mestre")]
        public ActionResult SalvarConvitesAceitos(ConviteMestreViewModel convite, Guid idConvite, string tipoNota,
            string listaIds, string listaAceite)
        {
            if (convite.Aceito)
            {
                convite.DataAceito = DateTime.Now;
                _conviteMestreAppService.Update(convite);
                // AtualizarQuestaoConviteAceito(listaIds, listaAceite);
                return RedirectToAction("AtualizarQuestaoConviteAceito", "Questao", new { @listaIds = listaIds, @listaAceite = listaAceite });

            }
	        _conviteMestreAppService.Update(convite);

	        return RedirectToAction("ListaConvites", "Mestre");
        }
       
        [Authorize(Roles = "Mestre")]
        public ActionResult ListaQuestoes()
        {
            var dadosMestre = _mestreAppService.Search(a => a.Email.Equals(User.Identity.Name)).FirstOrDefault();

            var listaQuestoes =
                _questaoAppService.Search(a => a.TopicoAtribuido.MestreId.Equals(dadosMestre.MestreId));

            return View(listaQuestoes);           
        }

	    public ActionResult SalvarQuestaoElaborada()
	    {
		    
	    }
	}
}
