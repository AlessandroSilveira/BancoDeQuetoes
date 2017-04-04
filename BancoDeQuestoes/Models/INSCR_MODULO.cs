namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_MODULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_MODULO()
        {
            INSCR_PERFIL_MODULO = new HashSet<INSCR_PERFIL_MODULO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MODULO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_MODULO { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [StringLength(150)]
        public string DESC_PAGINA { get; set; }

        public int? NUM_ORDEM { get; set; }

        [StringLength(50)]
        public string DESC_CHAVE { get; set; }

        [StringLength(50)]
        public string DESC_ICONE_MODULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PERFIL_MODULO> INSCR_PERFIL_MODULO { get; set; }
    }
}
