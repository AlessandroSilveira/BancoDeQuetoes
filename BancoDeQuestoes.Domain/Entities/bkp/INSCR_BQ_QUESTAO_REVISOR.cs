namespace BancoDeQuestoes.Domain.Entities
{
	public partial class INSCR_BQ_QUESTAO_REVISOR
    {
        public int ID_QUESTAO_REVISOR { get; set; }
        public int ID_REVISOR { get; set; }
        public int ID_QUESTAO { get; set; }
        public string DESC_DATA_ENTREGA { get; set; }
        public string DESC_STATUS { get; set; }
        public string DESC_VALOR { get; set; }
        public string DESC_REVISAO_1 { get; set; }
        public string DESC_REVISAO_2 { get; set; }
        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }
		public virtual Revisor Revisor { get; set; }
    }
}
