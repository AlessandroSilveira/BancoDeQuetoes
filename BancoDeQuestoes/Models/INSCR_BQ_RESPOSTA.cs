namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_RESPOSTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_RESPOSTA()
        {
            INSCR_BQ_RESPOSTA_REVISADA = new HashSet<INSCR_BQ_RESPOSTA_REVISADA>();
        }

        [Key]
        public int ID_RESPOSTA { get; set; }

        public int ID_TOPICO_ATRIBUIDO { get; set; }

        public int ID_QUESTAO { get; set; }

        [Required]
        public string DESC_RESPOSTA { get; set; }

        [Required]
        [StringLength(10)]
        public string DESC_CORRECAO { get; set; }

        [Required]
        public string DESC_JUSTIFICATIVA { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        public string DESC_OBSERVACAO_REVISOR { get; set; }

        public string DESC_OBSERVACAO_REVISOR_2 { get; set; }

        [StringLength(250)]
        public string DESC_IMAGEM { get; set; }

        [StringLength(250)]
        public string DESC_IMAGEM_JUSTIFICATIVA { get; set; }

        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }

        public virtual INSCR_BQ_TOPICO_ATRIBUIDO INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
    }
}
