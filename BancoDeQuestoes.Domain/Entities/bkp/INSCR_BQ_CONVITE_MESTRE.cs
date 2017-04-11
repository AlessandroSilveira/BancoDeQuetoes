using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
	public  class INSCR_BQ_CONVITE_MESTRE
    {
        public int ID_CONVITE_MESTRE { get; set; }
        public int ID_CONVITE { get; set; }
        public int ID_MESTRE { get; set; }
        public int ID_TOPICO_ATRIBUIDO { get; set; }
        public int NUM_QUESTAO { get; set; }
        public int DESC_ACEITE { get; set; }
        public string TIPO_PAGAMENTO { get; set; }
        public string DESC_VALOR { get; set; }
        public string DATA_ACEITE { get; set; }
        public virtual INSCR_BQ_MESTRE INSCR_BQ_MESTRE { get; set; }
        public virtual INSCR_BQ_TOPICO_ATRIBUIDO INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
