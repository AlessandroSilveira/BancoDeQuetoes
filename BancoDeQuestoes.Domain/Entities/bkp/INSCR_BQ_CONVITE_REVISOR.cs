using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
	public  class INSCR_BQ_CONVITE_REVISOR
    {
        public int ID_CONVITE_REVISOR { get; set; }
        public int ID_CONVITE { get; set; }
        public int ID_REVISOR { get; set; }
        public int? ID_QUESTAO { get; set; }
        public int NUM_QUESTAO { get; set; }
        public int DESC_ACEITE { get; set; }
        public string TIPO_PAGAMENTO { get; set; }
        public string DESC_VALOR { get; set; }
        public string DATA_ACEITE { get; set; }
        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }
        public virtual Revisor Revisor { get; set; }
    }
}
