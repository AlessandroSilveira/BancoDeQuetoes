using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Mestre
	{
		public int MestreId { get; set; }

		public string Nome { get; set; }

		

		public bool Ativo { get; set; }
	}
}
