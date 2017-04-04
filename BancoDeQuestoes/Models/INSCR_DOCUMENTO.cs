namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_DOCUMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_DOCUMENTO()
        {
            INSCR_CAD_DOCUMENTO = new HashSet<INSCR_CAD_DOCUMENTO>();
        }

        [Key]
        public int ID_DOCUMENTO { get; set; }

        public int ID_CONCURSO { get; set; }

        [Required]
        [StringLength(150)]
        public string DESC_DOCUMENTO { get; set; }

        [Required]
        [StringLength(4000)]
        public string DESC_DESCRICAO { get; set; }

        [StringLength(50)]
        public string DESC_CONDICAO_CAMPO { get; set; }

        [StringLength(50)]
        public string DESC_CONDICAO_VALOR { get; set; }

        public int ID_ADMIN { get; set; }

        public DateTime DT_INCLUSAO { get; set; }

        public virtual INSCR_ADMIN INSCR_ADMIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CAD_DOCUMENTO> INSCR_CAD_DOCUMENTO { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }
    }
}
