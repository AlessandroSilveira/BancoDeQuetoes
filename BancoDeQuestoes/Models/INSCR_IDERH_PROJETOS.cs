namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDERH_PROJETOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_IDERH_PROJETOS()
        {
            INSCR_IDERH_CAD_PROJETO = new HashSet<INSCR_IDERH_CAD_PROJETO>();
        }

        [Key]
        public int ID_IDERH_PROJETOS { get; set; }

        [Required]
        [StringLength(150)]
        public string DESC_IDERH_PROJETOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_IDERH_CAD_PROJETO> INSCR_IDERH_CAD_PROJETO { get; set; }
    }
}
