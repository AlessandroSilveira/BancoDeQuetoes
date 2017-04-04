namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SISREC_ORGAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SISREC_ORGAO()
        {
            SISREC_CARGOS = new HashSet<SISREC_CARGOS>();
            SISREC_DEPARTAMENTO = new HashSet<SISREC_DEPARTAMENTO>();
            SISREC_SETOR_SERVICO = new HashSet<SISREC_SETOR_SERVICO>();
        }

        [Key]
        public int ID_ORGAO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_ORGAO { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SISREC_CARGOS> SISREC_CARGOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SISREC_DEPARTAMENTO> SISREC_DEPARTAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SISREC_SETOR_SERVICO> SISREC_SETOR_SERVICO { get; set; }
    }
}
