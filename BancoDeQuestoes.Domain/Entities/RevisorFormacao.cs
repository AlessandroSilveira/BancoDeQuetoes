namespace BancoDeQuestoes.Domain.Entities
{
	public class RevisorFormacao
	{
		public int FormacaoRevisorId { get; set; }
		public int RevisorId { get; set; }
		public string Formacao { get; set; }
		public string Instituicao { get; set; }
		public bool Ativo { get; set; }

		public virtual Revisor Revisor { get; set; }
	}
}
