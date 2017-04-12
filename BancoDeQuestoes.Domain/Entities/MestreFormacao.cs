namespace BancoDeQuestoes.Domain.Entities
{
	public class MestreFormacao
	{
		public int MestreFormacaoId { get; set; }
		public int MestreId { get; set; }
		public string TipoFormacao { get; set; }
		public string Curso { get; set; }
		public string Instituicao { get; set; }
		public bool CopiaDiploma { get; set; }
		public bool DiplomaAutenticado { get; set; }
		public int NumeroCopiaAutenticada { get; set; }
		public bool Ativo { get; set; }

		public virtual Mestre Mestre { get; set; }
	}
}
