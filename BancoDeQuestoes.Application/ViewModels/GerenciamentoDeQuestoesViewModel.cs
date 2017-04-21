using System;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class GerenciamentoDeQuestoesViewModel 
	{
		public GerenciamentoDeQuestoesViewModel()
		{
			ProjetoId = new Guid();
			AreaId = new Guid();
			MestreId = new Guid();
			StatusId = new Guid();
			DisciplinaId = new Guid();
			QuestaoId = new Guid();
		}


		public Guid ProjetoId { get; set; }
		public Guid AreaId { get; set; }
		public Guid MestreId { get; set; }
		public Guid StatusId { get; set; }
		public Guid QuestaoId { get; set; }
		public Guid DisciplinaId { get; set; }
		public DateTime DataEntrega { get; set; }
		public string DescricaoDisciplina { get; set; }
		public int ItensPorPagina { get; set; }
		public string DescricaoQuestao { get; set; }
	}
}