namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_QUESTAO_REVISADA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_QUESTAO_REVISADA()
        {
            INSCR_BQ_QUESTAO_PROJETO = new HashSet<INSCR_BQ_QUESTAO_PROJETO>();
        }

        [Key]
        public int ID_QUESTAO_REVISADA { get; set; }

        public int ID_REVISOR { get; set; }

        public int ID_QUESTAO { get; set; }

        public int ID_TOPICO_ATRIBUIDO { get; set; }

        public int NUM_QUESTAO { get; set; }

        [Required]
        public string DESC_QUESTAO { get; set; }

        [Required]
        public string DESC_ARQUIVO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        public int NUM_REVISAO { get; set; }

        public string DESC_OBSERVACAO_REVISOR { get; set; }

        public string DESC_OBSERVACAO_REVISOR_2 { get; set; }

        [StringLength(50)]
        public string DATA_APROVACAO { get; set; }

        public string DESC_OBSERVACAO_RECUSA { get; set; }

        [StringLength(50)]
        public string DESC_IMAGEM { get; set; }

        [StringLength(1)]
        public string DESC_REVISAO_1 { get; set; }

        [StringLength(1)]
        public string DESC_REVISAO_2 { get; set; }

        public string DESC_JUSTIFICATIVA_REVISAO { get; set; }

        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_PROJETO> INSCR_BQ_QUESTAO_PROJETO { get; set; }

        public virtual INSCR_BQ_REVISOR INSCR_BQ_REVISOR { get; set; }

        public virtual INSCR_BQ_TOPICO_ATRIBUIDO INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
