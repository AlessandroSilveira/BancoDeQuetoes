using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Status
	{
		public Status()
		{
			StatusId = Guid.NewGuid();
		}

		public Guid StatusId { get; set; }
		public string Nome { get; set; }
		public bool Ativo { get; set; }
	}
}
