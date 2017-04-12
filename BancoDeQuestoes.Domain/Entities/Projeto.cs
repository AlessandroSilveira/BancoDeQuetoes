using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
    public  class Projeto
    {
        public int ProjetoId { get; set; }
        public int CodigoProjeto { get; set; }
        public string NomeProjeto { get; set; }
        public string Ativo { get; set; }

		public virtual IEnumerable<TopicoAtribuido> TopicoAtribuido { get; set; }
	}
}
