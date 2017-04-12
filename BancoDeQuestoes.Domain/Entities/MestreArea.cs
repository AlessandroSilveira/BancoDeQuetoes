namespace BancoDeQuestoes.Domain.Entities
{
	public class MestreArea
	{
		public int MestreAreaId { get; set; }
		public int MestreId { get; set; }
		public int AreaId { get; set; }
		public string Nome { get; set; }
		public bool Ativo { get; set; }

		public virtual Mestre Mestre { get; set; }
		public virtual Area Area { get; set; }
	}
}
