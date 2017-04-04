namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_TEMA_REDACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_TEMA_REDACAO()
        {
            INSCR_PROVA_PROCESSO = new HashSet<INSCR_PROVA_PROCESSO>();
        }

        [Key]
        public int ID_TEMA_REDACAO { get; set; }

        public int ID_CONCURSO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_REDACAO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESC_ARQUIVO { get; set; }

        public int NUM_ATIVO { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PROCESSO> INSCR_PROVA_PROCESSO { get; set; }
    }
}
