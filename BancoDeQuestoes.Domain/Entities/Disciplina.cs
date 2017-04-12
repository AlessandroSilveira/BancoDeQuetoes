using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Disciplina
    {
        public int DisciplinaId { get; set; }
		public int AreaId { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Bibliografia { get; set; }
        public bool Ativo { get; set; }
        public string Nivel { get; set; }

        public virtual Area Area { get; set; }

		public virtual IEnumerable<TopicoAtribuido> TopicoAtribuido { get; set; }
	}
}
