namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PERFIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PERFIL()
        {
            INSCR_ADMIN_PERFIL = new HashSet<INSCR_ADMIN_PERFIL>();
            INSCR_PERFIL_MODULO = new HashSet<INSCR_PERFIL_MODULO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PERFIL { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_PERFIL { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_ADMIN_PERFIL> INSCR_ADMIN_PERFIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PERFIL_MODULO> INSCR_PERFIL_MODULO { get; set; }
    }
}
