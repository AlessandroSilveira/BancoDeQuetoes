using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
	public class INSCR_BQ_RESPOSTA_REVISADA
    {
        public int ID_RESPOSTA_REVISADA { get; set; }
        public int ID_REVISOR { get; set; }
        public int ID_RESPOSTA { get; set; }
        public int ID_QUESTAO { get; set; }
        public int ID_TOPICO_ATRIBUIDO { get; set; }
        public string DESC_RESPOSTA { get; set; }
        public string DESC_CORRECAO { get; set; }
        public string DESC_JUSTIFICATIVA { get; set; }
        public string DESC_STATUS { get; set; }
        public string DESC_OBSERVACAO_REVISOR { get; set; }
        public string DESC_OBSERVACAO_REVISOR_2 { get; set; }
        public int? NUM_REVISAO { get; set; }
        public string DESC_IMAGEM { get; set; }
        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }
        public virtual INSCR_BQ_RESPOSTA INSCR_BQ_RESPOSTA { get; set; }
        public virtual Revisor Revisor { get; set; }
        public virtual INSCR_BQ_TOPICO_ATRIBUIDO INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
