namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_ADMIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_ADMIN()
        {
            INSCR_ADMIN_PERFIL = new HashSet<INSCR_ADMIN_PERFIL>();
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ADMIN { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_NOME { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_PERFIL { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_SENHA { get; set; }

        [StringLength(50)]
        public string DESC_USUARIO { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [StringLength(80)]
        public string DESC_EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_ADMIN_PERFIL> INSCR_ADMIN_PERFIL { get; set; }

      
    }
}
