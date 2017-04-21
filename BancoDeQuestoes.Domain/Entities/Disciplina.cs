using System;
using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Disciplina
    {
		public Disciplina()
		{
			DisciplinaId = Guid.NewGuid();
			
		}


		public Guid DisciplinaId { get; set; }
		public Guid AreaId { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Bibliografia { get; set; }
        public bool Ativo { get; set; }
        public string Nivel { get; set; }

        public virtual Area Area { get; set; }

		public virtual ICollection<TopicoAtribuido> TopicoAtribuidos { get; set; } = new List<TopicoAtribuido>();
	}
}
