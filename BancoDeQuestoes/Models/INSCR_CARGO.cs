namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CARGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_CARGO()
        {
            INSCR_CAD = new HashSet<INSCR_CAD>();
            INSCR_LOCAL_CARGO = new HashSet<INSCR_LOCAL_CARGO>();
            INSCR_PESSOA_CONCURSO = new HashSet<INSCR_PESSOA_CONCURSO>();
            INSCR_PROVA_PROCESSO_CARGO = new HashSet<INSCR_PROVA_PROCESSO_CARGO>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONCURSO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string RG_CARGO { get; set; }

        [StringLength(200)]
        public string CARGO_NOME { get; set; }

        [Column(TypeName = "money")]
        public decimal? CARGO_VALOR { get; set; }

        [StringLength(1)]
        public string CARGO_VALIDADE { get; set; }

        [StringLength(1000)]
        public string CARGO_PRERREQUISITO { get; set; }

        [StringLength(50)]
        public string CARGO_DETALHE { get; set; }

        public int? CARGO_QTDEMAX { get; set; }

        public int? CARGO_QTDEINSCRITOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CAD> INSCR_CAD { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_LOCAL_CARGO> INSCR_LOCAL_CARGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_CONCURSO> INSCR_PESSOA_CONCURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PROCESSO_CARGO> INSCR_PROVA_PROCESSO_CARGO { get; set; }
    }
}
