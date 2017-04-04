namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_RESULTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_RESULTADO()
        {
            INSCR_CANDIDATO_SEBRAE = new HashSet<INSCR_CANDIDATO_SEBRAE>();
            INSCR_PESSOA_RESULTADO = new HashSet<INSCR_PESSOA_RESULTADO>();
            INSCR_PESSOA_RESULTADO_OFICIAL = new HashSet<INSCR_PESSOA_RESULTADO_OFICIAL>();
            INSCR_RESULTADO_CAD_HISTORICO = new HashSet<INSCR_RESULTADO_CAD_HISTORICO>();
            INSCR_RESULTADO_CAD = new HashSet<INSCR_RESULTADO_CAD>();
            INSCR_RESULTADO_COLUNA = new HashSet<INSCR_RESULTADO_COLUNA>();
            INSCR_RESULTADO_COLUNA1 = new HashSet<INSCR_RESULTADO_COLUNA1>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RESULTADO { get; set; }

        public int ID_CONCURSO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_RESULTADO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_TIPO { get; set; }

        public DateTime? DESC_DATA_INICIAL { get; set; }

        public DateTime? DESC_DATA_FINAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CANDIDATO_SEBRAE> INSCR_CANDIDATO_SEBRAE { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_RESULTADO> INSCR_PESSOA_RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_RESULTADO_OFICIAL> INSCR_PESSOA_RESULTADO_OFICIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_RESULTADO_CAD_HISTORICO> INSCR_RESULTADO_CAD_HISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_RESULTADO_CAD> INSCR_RESULTADO_CAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_RESULTADO_COLUNA> INSCR_RESULTADO_COLUNA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_RESULTADO_COLUNA1> INSCR_RESULTADO_COLUNA1 { get; set; }
    }
}
