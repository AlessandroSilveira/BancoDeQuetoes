namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SISREC_DEPARTAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SISREC_DEPARTAMENTO()
        {
            SISREC_SETOR_SERVICO = new HashSet<SISREC_SETOR_SERVICO>();
        }

        [Key]
        public int ID_DEPARTAMENTO { get; set; }

        public int ID_ORGAO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESC_DEPARTAMENTO { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public virtual SISREC_ORGAO SISREC_ORGAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SISREC_SETOR_SERVICO> SISREC_SETOR_SERVICO { get; set; }
    }
}
