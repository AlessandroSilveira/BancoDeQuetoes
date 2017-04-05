using System.ComponentModel;

namespace BancoDeQuestoes.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class INSCR_BQ_TOPICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_TOPICO()
        {
            INSCR_BQ_TOP_DISC_CARGO = new HashSet<INSCR_BQ_TOP_DISC_CARGO>();
            INSCR_BQ_TOPICO_ATRIBUIDO = new HashSet<INSCR_BQ_TOPICO_ATRIBUIDO>();
        }

        [Key]
        [DisplayName("ID Tópico")]
        public int ID_TOPICO { get; set; }

		[DisplayName("Área")]
		public int ID_DISCIPLINA { get; set; }

	    [ScaffoldColumn(false), DisplayName("Cargo")]
	    public int? ID_CARGO { get; set; }

        [StringLength(250)]
        [DisplayName("Titulo do Tópico")]
        public string DESC_TITULO { get; set; }

        [DisplayName("Descrição do Tópico")]
        public string DESC_TOPICO { get; set; }

        [DisplayName("Bibliografia")]
        public string DESC_BIBLIOGRAFIA { get; set; }

        [StringLength(1)]
        [DisplayName("Ativo")]
        public string DESC_ATIVO { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Nível")]
        public string DESC_NIVEL { get; set; }

        public virtual INSCR_BQ_CARGO_CBO INSCR_BQ_CARGO_CBO { get; set; }

        public virtual INSCR_BQ_DISCIPLINA INSCR_BQ_DISCIPLINA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
