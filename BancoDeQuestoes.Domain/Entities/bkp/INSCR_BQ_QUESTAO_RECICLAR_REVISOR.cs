namespace BancoDeQuestoes.Domain.Entities
{
	public  class INSCR_BQ_QUESTAO_RECICLAR_REVISOR
    {
        public int ID_QUESTAO_RECICLAR_REVISOR { get; set; }
        public int ID_REVISOR { get; set; }
        public int ID_QUESTAO { get; set; }
        public string DESC_DATA_ENTREGA { get; set; }
        public string DESC_STATUS { get; set; }
        public string DESC_VALOR { get; set; }
        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }
        public virtual Revisor Revisor { get; set; }
    }
}
