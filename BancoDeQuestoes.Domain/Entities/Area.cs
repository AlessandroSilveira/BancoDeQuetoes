
using System;
using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
	public  class Area
	{
		public Area()
		{
			AreaId = Guid.NewGuid();
		}

		public Guid AreaId { get; set; }
		public string Descricao { get; set; }
		public bool ConhecimentoEspecifico { get; set; }
		public bool Ativo { get; set; }

		public virtual  ICollection<TopicoAtribuido> TopicoAtribuidos { get; set; } = new List<TopicoAtribuido>();
		public virtual ICollection<Disciplina> Disciplina { get; set; } = new List<Disciplina>();
	}
}
