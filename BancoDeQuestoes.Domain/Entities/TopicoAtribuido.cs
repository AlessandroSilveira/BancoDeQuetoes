using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public class TopicoAtribuido
	{

		public TopicoAtribuido()
		{
			TopicoAtribuidoId = Guid.NewGuid();
		}

		public Guid TopicoAtribuidoId { get; set; }
		public Guid ProjetoId { get; set; }
		public Guid AreaId { get; set; }
		public Guid MestreId { get; set; }
		public Guid DisciplinaId { get; set; }
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
