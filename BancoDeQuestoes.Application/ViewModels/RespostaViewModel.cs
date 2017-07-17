using System;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class RespostaViewModel
	{
		public RespostaViewModel()
		{
			RespostaId = Guid.NewGuid();
		}

		public Guid RespostaId { get; set; }
		public Guid TopicoAtribuidoId { get; set; }
		public Guid QuestaoId { get; set; }
		public string Descricao { get; set; }
		public string Correcao { get; set; }
		public string Jistificativa { get; set; }
		public string Status { get; set; }
		public string ObservacaoRevisor { get; set; }
		public string ObservacaoRevisor2 { get; set; }
		public string Imagem { get; set; }
		public string ImagemJustificativa { get; set; }
		public string Justificativa { get; set; }
	}
}
