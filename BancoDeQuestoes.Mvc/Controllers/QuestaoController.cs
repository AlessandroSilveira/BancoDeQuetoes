using System;
using System.Linq;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class QuestaoController : Controller
	{
		private readonly IQuestaoAppService _questaoAppService;
		private readonly IStatusAppService _statusAppService;
		private readonly IMestreAppService _mestreAppService;
		private readonly IRespostaAppService _respostaAppService;
		private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;

		public QuestaoController(IQuestaoAppService questaoAppService, IStatusAppService statusAppService,
			IMestreAppService mestreAppService, IRespostaAppService respostaAppService, ITopicoAtribuidoAppService topicoAtribuidoAppService)
		{
			_questaoAppService = questaoAppService;
			_statusAppService = statusAppService;
			_mestreAppService = mestreAppService;
			_respostaAppService = respostaAppService;
			_topicoAtribuidoAppService = topicoAtribuidoAppService;
		}

		// GET: Questao
		public ActionResult Index()
		{
			var questaoViewModels = _questaoAppService.GetAll();
			return View(questaoViewModels.ToList());
		}

		// GET: Questao/Details/5
		public ActionResult Details(Guid id)
		{
			var questaoViewModel = _statusAppService.GetById(id);
			if (questaoViewModel == null)
				return HttpNotFound();
			return View(questaoViewModel);
		}

		// GET: Questao/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Questao/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(QuestaoViewModel questaoViewModel)
		{
			if (!ModelState.IsValid) return View(questaoViewModel);
			_questaoAppService.Add(questaoViewModel);
			return RedirectToAction("Index");
		}

		// GET: Questao/Edit/5
		public ActionResult Edit(Guid id)
		{
			var projeto = _questaoAppService.GetById(id);
			return View(projeto);
		}

		// POST: Questao/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(QuestaoViewModel questaoViewModel)
		{
			if (!ModelState.IsValid) return View(questaoViewModel);
			_questaoAppService.Update(questaoViewModel);
			return RedirectToAction("Index");
		}

		// GET: Questao/Delete/5
		public ActionResult Delete(Guid id)
		{
			var projeto = _questaoAppService.GetById(id);
			return View(projeto);
		}

		// POST: Questao/Delete/5
		[HttpPost]
		[ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			_questaoAppService.Remove(id);
			return RedirectToAction("Index");
		}

		public ActionResult AtualizarQuestaoConviteAceito(string listaIds, string listaAceite)
		{
			var questoesId = listaIds.Split(',');
			var questoesAceitas = listaAceite.Split(',');
			var status = _statusAppService.ObterDescricaoStatus("Convite Aceito");
			for (var i = 0; i < questoesId.Length; i++)
			{
				var dadosQuestoes = _questaoAppService.GetById(new Guid(questoesId[i]));
				dadosQuestoes.ConviteAceito = questoesAceitas[i] == "1";
				dadosQuestoes.Status = status.Nome;
				_questaoAppService.Update(dadosQuestoes);
			}
			return RedirectToAction("ListaQuestoes", "Mestre");
		}

		[Authorize(Roles = "Mestre")]
		public ActionResult PainelQuestao(Guid id)
		{
			TempData["DadoaQuestao"] = _questaoAppService.GetById(id);
			ViewBag.DadosMestre = _mestreAppService.Search(a => a.Email.Equals(User.Identity.Name)).FirstOrDefault();
			ViewBag.DadosRespostas = _respostaAppService.Search(a => a.QuestaoId.Equals(id));
			return View();
		}

		[Authorize(Roles = "Mestre")]
		[HttpPost]
		public ActionResult SalvarQuestaoElaborada(Guid QuestaoId, string Questao)
		{
			try
			{
				var dadosQuestao = _questaoAppService.GetById(QuestaoId);
				dadosQuestao.Descricao = Questao;
				dadosQuestao.Status = "Item Elaborado aguardando ser enviado para Revisão da banca";
				_questaoAppService.Update(dadosQuestao);

				AtualizarStatusTopicoAtribuido(dadosQuestao);

				return Json(true, JsonRequestBehavior.AllowGet);
			}
			catch (Exception)
			{
				return Json(false, JsonRequestBehavior.AllowGet);
			}
		}

		private void AtualizarStatusTopicoAtribuido(QuestaoViewModel dadosQuestao)
		{
			var dadosTipoco = _topicoAtribuidoAppService.GetById(dadosQuestao.TopicoAtribuidoId);
			dadosTipoco.Status = dadosQuestao.Status;
			_topicoAtribuidoAppService.Update(dadosTipoco);
		}

		[Authorize(Roles = "Mestre")]
		[HttpPost]
		public ActionResult SalvarRespostasEJustificativasElaboradas(Guid QuestaoId, string resposta, string justificativa)
		{
			try
			{
				var dadosQuestao = _questaoAppService.GetById(QuestaoId);

				var dadosResposta = new RespostaViewModel
				{
					TopicoAtribuidoId = dadosQuestao.TopicoAtribuidoId,
					QuestaoId = dadosQuestao.QuestaoId,
					Descricao = resposta,
					Justificativa = justificativa,
					Correcao = "",
					Status = "",
					ObservacaoRevisor = "",
					ObservacaoRevisor2 = "",
					Imagem = "",
					ImagemJustificativa = ""
				};

				_respostaAppService.Add(dadosResposta);

				return Json(true, JsonRequestBehavior.AllowGet);
			}
			catch (Exception)
			{
				return Json(false, JsonRequestBehavior.AllowGet);
			}
		}
	}
}
