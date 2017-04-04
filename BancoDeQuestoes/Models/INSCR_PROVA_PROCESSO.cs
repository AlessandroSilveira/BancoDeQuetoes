namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_PROCESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PROVA_PROCESSO()
        {
            INSCR_PROVA_PROCESSO_CARGO = new HashSet<INSCR_PROVA_PROCESSO_CARGO>();
            INSCR_PROVA_PROCESSO_LOCAL = new HashSet<INSCR_PROVA_PROCESSO_LOCAL>();
        }

        [Key]
        public int ID_PROVA_PROCESSO { get; set; }

        public int ID_CONCURSO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESC_PROCESSO { get; set; }

        [StringLength(50)]
        public string DESC_CHAVE { get; set; }

        public DateTime? DT_PROVA { get; set; }

        public int? ID_TEMA_REDACAO { get; set; }

        public int? ID_ADMIN { get; set; }

        [StringLength(20)]
        public string DESC_HORA_ABRE_PORTAO { get; set; }

        [StringLength(20)]
        public string DESC_HORA_FECHA_PORTAO { get; set; }

        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        [StringLength(50)]
        public string DESC_ORIGEM { get; set; }

        public virtual INSCR_ADMIN INSCR_ADMIN { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PROCESSO_CARGO> INSCR_PROVA_PROCESSO_CARGO { get; set; }

        public virtual INSCR_TEMA_REDACAO INSCR_TEMA_REDACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PROCESSO_LOCAL> INSCR_PROVA_PROCESSO_LOCAL { get; set; }
    }
}
