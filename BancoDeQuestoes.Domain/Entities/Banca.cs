using System;
using System.Collections.Generic;
using System.Net.Configuration;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Banca
	{
		public Banca()
		{
			BancaId = Guid.NewGuid();
		}
		public Guid BancaId { get; set; }
		public string Nome { get; set; }
		public decimal Valor{get; set; }
		public bool Ativo { get; set; }

		public virtual ICollection<Mestre> Mestres { get; set; } = new List<Mestre>();
	}
}
