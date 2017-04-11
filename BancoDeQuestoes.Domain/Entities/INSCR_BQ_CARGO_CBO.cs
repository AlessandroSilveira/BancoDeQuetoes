using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_CARGO_CBO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_CARGO_CBO()
        {
            INSCR_BQ_TOPICO_ATRIBUIDO = new HashSet<INSCR_BQ_TOPICO_ATRIBUIDO>();
            INSCR_BQ_TOPICO = new HashSet<Disciplina>();
            INSCR_BQ_TOP_DISC_CARGO = new HashSet<INSCR_BQ_TOP_DISC_CARGO>();
        }

        [Key]
        public int ID_CARGO_CBO { get; set; }

        [StringLength(250)]
        public string DESC_CARGO { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Disciplina> INSCR_BQ_TOPICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }
    }
}
