using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public class RevisorFormacao
	{

		public RevisorFormacao()
		{
			RevisorFormacaoId = Guid.NewGuid();
		}

		public Guid RevisorFormacaoId { get; set; }
		public Guid RevisorId { get; set; }
		public string Formacao { get; set; }
		public string Instituicao { get; set; }
		public bool Ativo { get; set; }

		public virtual  Revisor Revisor { get; set; }
	}
}
