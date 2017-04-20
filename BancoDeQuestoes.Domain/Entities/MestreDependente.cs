using System;
using System.ComponentModel;


namespace BancoDeQuestoes.Domain.Entities
{
	public class MestreDependente
	{
		public MestreDependente()
		{
				MestreDependenteId = Guid.NewGuid();
		}

		public Guid MestreDependenteId { get; set; }
		public Guid MestreId { get; set; }
		public string Nome { get; set; }
		public string Documento { get; set; }
		public DateTime DataNascimento { get; set; }
		public bool Ativo { get; set; }
		public virtual Mestre Mestre { get; set; }
	}
}
