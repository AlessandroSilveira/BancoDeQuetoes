using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public class MestreArea
	{
		public MestreArea()
		{
			MestreAreaId = Guid.NewGuid();
		}

		public Guid MestreAreaId { get; set; }
		public Guid MestreId { get; set; }
		public Guid AreaId { get; set; }
		public string Nome { get; set; }
		public bool Ativo { get; set; }

		public virtual  Mestre Mestre { get; set; }
		public virtual Area Area { get; set; }
	}
}
