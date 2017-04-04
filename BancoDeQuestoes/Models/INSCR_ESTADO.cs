namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_ESTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_ESTADO()
        {
            INSCR_CIDADE = new HashSet<INSCR_CIDADE>();
        }

        [Key]
        public byte EstadoId { get; set; }

        [Required]
        [StringLength(2)]
        public string Sigla { get; set; }

        [StringLength(50)]
        public string DESC_ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CIDADE> INSCR_CIDADE { get; set; }
    }
}
