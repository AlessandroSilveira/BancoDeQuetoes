namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_CIDADE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PROVA_CIDADE()
        {
            INSCR_PROVA_ESCOLA = new HashSet<INSCR_PROVA_ESCOLA>();
            INSCR_PROVA_PAGAMENTO = new HashSet<INSCR_PROVA_PAGAMENTO>();
        }

        [Key]
        public int ID_PROVA_CIDADE { get; set; }

        public int ID_PROVA { get; set; }

        public int ID_COORDENADOR { get; set; }

        public int? ID_PAGAMENTO_COORDENADOR { get; set; }

        [StringLength(50)]
        public string DESC_CIDADE { get; set; }

        public int? NUM_PREVISAO_INSCRITO { get; set; }

        [StringLength(1)]
        public string NUM_ACEITE { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public virtual INSCR_COORDENADOR INSCR_COORDENADOR { get; set; }

        public virtual INSCR_PROVA INSCR_PROVA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_ESCOLA> INSCR_PROVA_ESCOLA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PAGAMENTO> INSCR_PROVA_PAGAMENTO { get; set; }
    }
}
