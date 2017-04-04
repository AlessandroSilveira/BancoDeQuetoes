namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_LOCAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PROVA_LOCAL()
        {
            INSCR_PROVA_LOCAL_SALA = new HashSet<INSCR_PROVA_LOCAL_SALA>();
            INSCR_PROVA_PROCESSO_LOCAL = new HashSet<INSCR_PROVA_PROCESSO_LOCAL>();
        }

        [Key]
        public int ID_PROVA_LOCAL { get; set; }

        [Required]
        [StringLength(100)]
        public string DESC_PROVA_LOCAL { get; set; }

        [StringLength(100)]
        public string DESC_ENDERECO { get; set; }

        [StringLength(50)]
        public string DESC_BAIRRO { get; set; }

        [StringLength(50)]
        public string DESC_COMPL { get; set; }

        [StringLength(50)]
        public string DESC_CEP { get; set; }

        [StringLength(100)]
        public string DESC_CIDADE { get; set; }

        [StringLength(2)]
        public string DESC_UF { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public int? ID_ADMIN { get; set; }

        public virtual INSCR_ADMIN INSCR_ADMIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_LOCAL_SALA> INSCR_PROVA_LOCAL_SALA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PROCESSO_LOCAL> INSCR_PROVA_PROCESSO_LOCAL { get; set; }
    }
}
