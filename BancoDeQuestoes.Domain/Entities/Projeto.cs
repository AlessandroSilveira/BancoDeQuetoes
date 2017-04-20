using System;
using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
    public  class Projeto
    {
	    public Projeto()
	    {
		    ProjetoId = Guid.NewGuid();
	    }

        public Guid ProjetoId { get; set; }
        public int CodigoProjeto { get; set; }
        public string NomeProjeto { get; set; }
        public bool Ativo { get; set; }

		public virtual ICollection<TopicoAtribuido> TopicoAtribuidos { get; set; } = new List<TopicoAtribuido>();
	}
}
