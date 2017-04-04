namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_LOCAL_SALA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PROVA_LOCAL_SALA()
        {
            INSCR_PROVA_PROCESSO_LOCAL_SALA = new HashSet<INSCR_PROVA_PROCESSO_LOCAL_SALA>();
        }

        [Key]
        public int ID_PROVA_LOCAL_SALA { get; set; }

        public int ID_PROVA_LOCAL { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_SALA { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_ANDAR { get; set; }

        public int NUM_QTDE_CARTEIRAS { get; set; }

        public int NUM_ATIVO { get; set; }

        public int NUM_ACESSIBILIDADE { get; set; }

        public virtual INSCR_PROVA_LOCAL INSCR_PROVA_LOCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PROCESSO_LOCAL_SALA> INSCR_PROVA_PROCESSO_LOCAL_SALA { get; set; }
    }
}
