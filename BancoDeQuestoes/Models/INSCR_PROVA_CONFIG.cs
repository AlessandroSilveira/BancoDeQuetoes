namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_CONFIG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PROVA_CONFIG()
        {
            INSCR_PROVA_CONFIG_VALOR = new HashSet<INSCR_PROVA_CONFIG_VALOR>();
        }

        [Key]
        public int ID_CONFIG { get; set; }

        public string DESC_CONFIG { get; set; }

        public double? DESC_VALOR_PADRAO { get; set; }

        [StringLength(50)]
        public string DESC_LABEL { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_CONFIG_VALOR> INSCR_PROVA_CONFIG_VALOR { get; set; }
    }
}
