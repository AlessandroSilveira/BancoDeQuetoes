using System.Collections.Generic;

using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
    public class INSCR_BQ_TOPICO_ATRIBUIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_TOPICO_ATRIBUIDO()
        {
            INSCR_BQ_CONVITE_MESTRE = new HashSet<INSCR_BQ_CONVITE_MESTRE>();
            INSCR_BQ_QUESTAO = new HashSet<INSCR_BQ_QUESTAO>();
            INSCR_BQ_QUESTAO_REVISADA = new HashSet<INSCR_BQ_QUESTAO_REVISADA>();
            INSCR_BQ_RESPOSTA = new HashSet<INSCR_BQ_RESPOSTA>();
            INSCR_BQ_RESPOSTA_REVISADA = new HashSet<INSCR_BQ_RESPOSTA_REVISADA>();
        }
        
        public int ID_TOPICO_ATRIBUIDO { get; set; }
        public int ID_PROJETO { get; set; }
        public int AreaId { get; set; }
        public int? ID_CARGO { get; set; }
        public int COD_PROJETO { get; set; }
        public int ID_MESTRE { get; set; }
        public int ID_TOPICO { get; set; }
        public int NUM_QUESTOES { get; set; }
        public int? QUESTOES_REALIZADAS { get; set; }
        public string DATA_ENTREGA { get; set; }
        public string DESC_STATUS { get; set; }
        public string DESC_NIVEL { get; set; }
        public string DESC_VALOR { get; set; }
        public string DESC_ACEITE { get; set; }
		public string DESC_OBSERVACAO { get; set; }
        public string DATA_ATRIBUICAO { get; set; }
        public virtual INSCR_BQ_CARGO_CBO INSCR_BQ_CARGO_CBO { get; set; }
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_CONVITE_MESTRE> INSCR_BQ_CONVITE_MESTRE { get; set; }
        public virtual Area Area { get; set; }
        public virtual INSCR_BQ_MESTRE INSCR_BQ_MESTRE { get; set; }
        public virtual Projeto Projeto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO> INSCR_BQ_QUESTAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_REVISADA> INSCR_BQ_QUESTAO_REVISADA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_RESPOSTA> INSCR_BQ_RESPOSTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}
