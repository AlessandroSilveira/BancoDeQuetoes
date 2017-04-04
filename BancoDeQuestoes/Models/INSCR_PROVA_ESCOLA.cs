namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_ESCOLA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PROVA_ESCOLA()
        {
            INSCR_PROVA_ESCOLA_RH = new HashSet<INSCR_PROVA_ESCOLA_RH>();
        }

        [Key]
        public int ID_PROVA_ESCOLA { get; set; }

        public int ID_COORDENADOR { get; set; }

        public int ID_ESCOLA { get; set; }

        public int ID_PROVA_CIDADE { get; set; }

        [StringLength(150)]
        public string DESC_OFICIO { get; set; }

        public int? NUM_ATIVO { get; set; }

        [StringLength(1)]
        public string DESC_MODO_PAGAMENTO { get; set; }

        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        [StringLength(50)]
        public string DESC_CONTRATACAO { get; set; }

        public int? NUM_VALOR { get; set; }

        public int? NUM_VALOR_TOTAL { get; set; }

        public virtual INSCR_COORDENADOR INSCR_COORDENADOR { get; set; }

        public virtual INSCR_ESCOLA INSCR_ESCOLA { get; set; }

        public virtual INSCR_PROVA_CIDADE INSCR_PROVA_CIDADE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_ESCOLA_RH> INSCR_PROVA_ESCOLA_RH { get; set; }
    }
}
