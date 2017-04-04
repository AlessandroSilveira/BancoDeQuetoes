using System.ComponentModel;

namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_BANCA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_BANCA()
        {
            INSCR_BQ_MESTRE = new HashSet<INSCR_BQ_MESTRE>();
        }

        [Key]
        public int ID_BANCA { get; set; }

        [StringLength(50)]
        [Required]
        [DisplayName("Descrição da Banca")]
        public string DESC_BANCA { get; set; }

        [StringLength(1)]
        [Required]
        [DisplayName("Ativo")]
        public string DESC_STATUS { get; set; }

        [StringLength(10)]
        [Required]
        [DisplayName("Valor de Porcentagem da Banca")]
        public string DESC_VALOR_PORCENTAGEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_MESTRE> INSCR_BQ_MESTRE { get; set; }
    }
}
