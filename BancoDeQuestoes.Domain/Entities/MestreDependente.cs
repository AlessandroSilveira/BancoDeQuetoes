using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public class MestreDependente
	{
		public int MestreDependenteId { get; set; }
		public int MestreId { get; set; }
		public string Nome { get; set; }
		public string Documento { get; set; }
		public DateTime DataNascimento { get; set; }
		public bool Ativo { get; set; }

		public virtual Mestre Mestre { get; set; }
	}
}
