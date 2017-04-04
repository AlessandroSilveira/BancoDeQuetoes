namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_ESCOLA_SALA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_ESCOLA_SALA()
        {
            INSCR_PROVA_ESCOLA_MAPA = new HashSet<INSCR_PROVA_ESCOLA_MAPA>();
        }

        [Key]
        public int ID_SALA { get; set; }

        public int ID_ESCOLA { get; set; }

        [StringLength(50)]
        public string DESC_SALA { get; set; }

        [StringLength(50)]
        public string DESC_ANDAR { get; set; }

        [StringLength(10)]
        public string DESC_BLOCO { get; set; }

        public int? NUM_QUANT_CARTEIRA { get; set; }

        [StringLength(250)]
        public string DESC_EXTRA { get; set; }

        [StringLength(1)]
        public string DESC_ATVO { get; set; }

        public virtual INSCR_ESCOLA INSCR_ESCOLA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_ESCOLA_MAPA> INSCR_PROVA_ESCOLA_MAPA { get; set; }
    }
}
