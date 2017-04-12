
using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
	public partial class Area
	{
		public int AreaId { get; set; }
		public string Descricao { get; set; }
		public bool ConhecimentoEspecifico { get; set; }
		public bool Ativo { get; set; }

		public virtual IEnumerable<TopicoAtribuido> TopicoAtribuido { get; set; }
	}
}
