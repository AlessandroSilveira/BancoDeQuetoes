using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public class TopicoAtribuido
	{
		public int TopicoAtribuidoId { get; set; }
		public int ProjetoId { get; set; }
		public int AreaId { get; set; }
		public int MestreId { get; set; }
		public int DisciplinaId { get; set; }
		public string CodigoProjeto { get; set; }
		public int NumeroQuestao { get; set; }
		public DateTime DataEntrega { get; set; }
		public string Status { get; set; }
		public string Nivel { get; set; }
		public decimal Valor { get; set; }
		public int QuestoesRealizadas { get; set; }
		public bool Aceito { get; set; }
		public string Observacao { get; set; }
		public DateTime DataAtribuicao { get; set; }
		public bool ConviteAceito { get; set; }

		public virtual Projeto Projeto { get; set; }
		public virtual Area Area { get; set; }
		public virtual Mestre Mestre { get; set; }
		public virtual Disciplina Disciplina { get; set; }

	}
}
