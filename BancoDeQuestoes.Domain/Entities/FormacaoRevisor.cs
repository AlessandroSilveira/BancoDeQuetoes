using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeQuestoes.Domain.Entities
{
	public class FormacaoRevisor
	{
		public int FormacaoRevisorId { get; set; }
		public int RevisorId { get; set; }
		public string Formacao { get; set; }
		public string Instituicao { get; set; }
		public bool Ativo { get; set; }

		public virtual Revisor Revisor { get; set; }
	}
}
