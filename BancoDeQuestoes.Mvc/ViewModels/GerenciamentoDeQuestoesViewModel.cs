using System;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class GerenciamentoDeQuestoesViewModel
	{
		[Key]
		public int ProjetoId { get; set; }
		public int AreaId { get; set; }
		public int MestreId { get; set; }
		public int StatusId { get; set; }
		public int QuestaoId { get; set; }
		public int DisciplinaId { get; set; }
		public DateTime DataEntrega { get; set; }
		public string DescricaoDisciplina { get; set; }
		public int ItensPorPagina { get; set; }
		public string DescricaoQuestao { get; set; }
	}
}