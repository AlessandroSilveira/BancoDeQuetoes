using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	[Authorize(Roles = "Admin")]
	public class TopicoAtribuidoController : Controller
	{
		private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;
		private readonly IStatusAppService _statusAppService;
		private readonly IConviteMestreAppService _conviteMestreAppService;
		private readonly IQuestaoAppService _questaoAppService;

		public TopicoAtribuidoController(ITopicoAtribuidoAppService topicoAtribuidoAppService,
			IStatusAppService statusAppService, IConviteMestreAppService conviteMestreAppService,
			IQuestaoAppService questaoAppService)
		{
			_topicoAtribuidoAppService = topicoAtribuidoAppService;
			_statusAppService = statusAppService;
			_conviteMestreAppService = conviteMestreAppService;
			_questaoAppService = questaoAppService;
		}

		public ActionResult Index()
		{
			return View(_topicoAtribuidoAppService.GetAll());
		}

		public ActionResult Details(Guid id)
		{
			var topico = _topicoAtribuidoAppService.GetById(id);
			return topico == null ? (ActionResult) HttpNotFound() : View(topico);
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(TopicoAtribuidoViewModel topicoAtribuidoViewModel)
		{
			if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
			_topicoAtribuidoAppService.Add(topicoAtribuidoViewModel);
			return RedirectToAction("Index");
		}

		public ActionResult Edit(Guid id)
		{
			var topico = _topicoAtribuidoAppService.GetById(id);
			return View(topico);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(TopicoAtribuidoViewModel topicoAtribuidoViewModel)
		{
			if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
			_topicoAtribuidoAppService.Update(topicoAtribuidoViewModel);
			return RedirectToAction("Index");
		}

		public ActionResult Delete(Guid id)
		{
			return View(_topicoAtribuidoAppService.GetById(id));
		}

		[HttpPost]
		[ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(Guid id)
		{
			_topicoAtribuidoAppService.Remove(id);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public ActionResult SalvarTopicoAtribuido(Guid ProjetoId, Guid AreaId, Guid MestreId, decimal inputValor,
			DateTime inputData,
			int inputNumQuestao, string Nivel, string inputObservacoes, string Disciplinas_selecionadas)
		{
			if (!ModelState.IsValid) return View();

			var idDiscipliina = Disciplinas_selecionadas.Split(',');
			var status = _statusAppService.ObterDescricaoStatus("Item sem confirmação de aceite pelo Elaborador").ToString();

			foreach (var dados in idDiscipliina)
			{
				var dadosTopico = CriarTopicoAtribuido(ProjetoId, AreaId, MestreId, inputValor, inputData,
					inputNumQuestao, Nivel, inputObservacoes, dados, status);
				CriarConviteDoMestre(inputValor, inputNumQuestao, dadosTopico);

				for (var i = 1; i <= inputNumQuestao; i++)
					AdicionarQuestoes(i, Nivel, dadosTopico, status);
			}

			return View();
		}

		private void AdicionarQuestoes(int inputNumQuestao, string Nivel, TopicoAtribuidoViewModel dadosTopico,
			string status)
		{
			var questao = new QuestaoViewModel
			{
				TopicoAtribuidoId = dadosTopico.TopicoAtribuidoId,
				NumeroQuestao = inputNumQuestao,
				Status = status,
				Arquivo = "",
				ConviteAceito = false,
				Descricao = "",
				Finalizar = 0,
				Imagem = "",
				Nivel = Nivel,
				NumeroDeRevisoes = 0
			};
			_questaoAppService.Add(questao);
		}

		private void CriarConviteDoMestre(decimal inputValor, int inputNumQuestao, TopicoAtribuidoViewModel dadosTopico)
		{
			var convite = new ConviteMestreViewModel
			{
				TopicoAtribuidoId = dadosTopico.TopicoAtribuidoId,
				MestreId = dadosTopico.MestreId,
				NumeroQuestao = inputNumQuestao,
				Aceito = false,
				TipoPagamento = "",
				Valor = inputValor
			};

			_conviteMestreAppService.Add(convite);
		}

		private TopicoAtribuidoViewModel CriarTopicoAtribuido(Guid ProjetoId, Guid AreaId, Guid MestreId,
			decimal inputValor,
			DateTime inputData, int inputNumQuestao, string Nivel, string inputObservacoes, string dados,
			string status)
		{
			var form = new TopicoAtribuidoViewModel
			{
				ProjetoId = ProjetoId,
				AreaId = AreaId,
				MestreId = MestreId,
				Valor = inputValor,
				DataEntrega = inputData,
				NumeroQuestao = inputNumQuestao,
				Nivel = Nivel,
				Observacao = inputObservacoes,
				CodigoProjeto = _topicoAtribuidoAppService.ObterCodigoProjeto(ProjetoId).ToString(),
				DataAtribuicao = DateTime.Now,
				DisciplinaId = new Guid(dados),
				Status = status
			};

			var dadosTopico = _topicoAtribuidoAppService.Add(form);
			return dadosTopico;
		}


		public ActionResult ExcluirTopicoAtribuido(Guid id)
		{
			ActionResult redirectToAction;
			if (RemoverQuestaoPorTopicoAtribuidoId(id, out redirectToAction)) return redirectToAction;

			RemoverConviteMestrePorTopicoAtribuidoId(id);

			_topicoAtribuidoAppService.Remove(id);

			return RedirectToAction("Index", "TopicoAtribuido");
		}

		private void RemoverConviteMestrePorTopicoAtribuidoId(Guid id)
		{
			var dadosConvite = _conviteMestreAppService.Search(a => a.TopicoAtribuidoId.Equals(id));

			foreach (var itens in dadosConvite)
				_conviteMestreAppService.Remove(itens.ConviteMestreId);
		}

		private bool RemoverQuestaoPorTopicoAtribuidoId(Guid id, out ActionResult redirectToAction)
		{
			var dadosQuestoes =
				_questaoAppService.Search(a => a.TopicoAtribuidoId.Equals(id) &&
				                               a.Status.Equals("Item sem confirmação de aceite pelo Elaborador"));

			if (dadosQuestoes == null)
			{
				redirectToAction = RedirectToAction("Index", "TopicoAtribuido");
				return true;
			}

			foreach (var itens in dadosQuestoes)
				_questaoAppService.Remove(itens.QuestaoId);
			redirectToAction = null;
			return false;
		}
	}
}
