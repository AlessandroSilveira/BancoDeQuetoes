namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_PROCESSO_LOCAL_SALA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PROVA_PROCESSO_LOCAL_SALA()
        {
            INSCR_PROVA_CAD = new HashSet<INSCR_PROVA_CAD>();
        }

        [Key]
        public int ID_SALA { get; set; }

        public int ID_PROVA_PROCESSO_LOCAL { get; set; }

        public int ID_PROVA_LOCAL_SALA { get; set; }

        public int NUM_ORDEM { get; set; }

        public int NUM_QTDE_CARTEIRAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_CAD> INSCR_PROVA_CAD { get; set; }

        public virtual INSCR_PROVA_LOCAL_SALA INSCR_PROVA_LOCAL_SALA { get; set; }

        public virtual INSCR_PROVA_PROCESSO_LOCAL INSCR_PROVA_PROCESSO_LOCAL { get; set; }
    }
}
