namespace BancoDeQuestoes.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class INSCR_BQ_DISCIPLINA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_DISCIPLINA()
        {
            INSCR_BQ_TOPICO_ATRIBUIDO = new HashSet<INSCR_BQ_TOPICO_ATRIBUIDO>();
            INSCR_BQ_TOPICO = new HashSet<INSCR_BQ_TOPICO>();
            INSCR_BQ_TOP_DISC_CARGO = new HashSet<INSCR_BQ_TOP_DISC_CARGO>();
        }

        [Key]
        public int ID_DISCIPLINA { get; set; }

        [StringLength(250)]
        [DisplayName("Área")]
        public string DESC_DISCIPLINA { get; set; }

        [StringLength(1)]
        [DisplayName("É Conhecimento Específico")]
        public string TIPO_CONH_ESPEC { get; set; }

        [StringLength(1)]
        [DisplayName("Ativo")]
        public string DESC_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOPICO> INSCR_BQ_TOPICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }
    }
}
