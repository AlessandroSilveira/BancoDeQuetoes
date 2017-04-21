using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public class MestreFormacao
	{

		public MestreFormacao()
		{
			MestreFormacaoId = Guid.NewGuid();
		}

		public Guid MestreFormacaoId { get; set; }
		public Guid MestreId { get; set; }
		public string TipoFormacao { get; set; }
		public string Curso { get; set; }
		public string Instituicao { get; set; }
		public bool CopiaDiploma { get; set; }
		public bool DiplomaAutenticado { get; set; }
		public int NumeroCopiaAutenticada { get; set; }
		public bool Ativo { get; set; }

		public virtual  Mestre Mestre { get; set; }
	}
}
