namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_LOCAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_LOCAL()
        {
            INSCR_LOCAL_CARGO = new HashSet<INSCR_LOCAL_CARGO>();
        }

        public int ID_CONCURSO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_LOCAL { get; set; }

        [Required]
        [StringLength(200)]
        public string DESC_LOCAL { get; set; }

        [StringLength(100)]
        public string DESC_ENDERECO { get; set; }

        [StringLength(100)]
        public string DESC_CIDADE { get; set; }

        [StringLength(2)]
        public string DESC_UF { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [StringLength(50)]
        public string DESC_NIVEL { get; set; }

        [StringLength(50)]
        public string DESC_NIVELB { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_LOCAL_CARGO> INSCR_LOCAL_CARGO { get; set; }
    }
}
