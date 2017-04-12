using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
	public partial class INSCR_BQ_RESPOSTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_RESPOSTA()
        {
            INSCR_BQ_RESPOSTA_REVISADA = new HashSet<INSCR_BQ_RESPOSTA_REVISADA>();
        }
		
        public int ID_RESPOSTA { get; set; }
        public int ID_TOPICO_ATRIBUIDO { get; set; }
        public int ID_QUESTAO { get; set; }
        public string DESC_RESPOSTA { get; set; }
        public string DESC_CORRECAO { get; set; }
        public string DESC_JUSTIFICATIVA { get; set; }
        public string DESC_STATUS { get; set; }
        public string DESC_OBSERVACAO_REVISOR { get; set; }
        public string DESC_OBSERVACAO_REVISOR_2 { get; set; }
        public string DESC_IMAGEM { get; set; }
        public string DESC_IMAGEM_JUSTIFICATIVA { get; set; }
        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }
        public virtual INSCR_BQ_TOPICO_ATRIBUIDO INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
    }
}
