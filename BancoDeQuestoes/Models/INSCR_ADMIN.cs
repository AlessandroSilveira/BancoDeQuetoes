namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_ADMIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_ADMIN()
        {
            INSCR_ADMIN_PERFIL = new HashSet<INSCR_ADMIN_PERFIL>();
            INSCR_CAD_DOCUMENTO = new HashSet<INSCR_CAD_DOCUMENTO>();
            INSCR_DOCUMENTO = new HashSet<INSCR_DOCUMENTO>();
            INSCR_OCORRENCIA = new HashSet<INSCR_OCORRENCIA>();
            INSCR_PROVA_LOCAL = new HashSet<INSCR_PROVA_LOCAL>();
            INSCR_PROVA_PROCESSO = new HashSet<INSCR_PROVA_PROCESSO>();
            INSCR_RESULTADO_CAD_ADMIN = new HashSet<INSCR_RESULTADO_CAD_ADMIN>();
            INSCR_RESULTADO_CAD_HISTORICO = new HashSet<INSCR_RESULTADO_CAD_HISTORICO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ADMIN { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_NOME { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_PERFIL { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_SENHA { get; set; }

        [StringLength(50)]
        public string DESC_USUARIO { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [StringLength(80)]
        public string DESC_EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_ADMIN_PERFIL> INSCR_ADMIN_PERFIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CAD_DOCUMENTO> INSCR_CAD_DOCUMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_DOCUMENTO> INSCR_DOCUMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_OCORRENCIA> INSCR_OCORRENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_LOCAL> INSCR_PROVA_LOCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PROCESSO> INSCR_PROVA_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_RESULTADO_CAD_ADMIN> INSCR_RESULTADO_CAD_ADMIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_RESULTADO_CAD_HISTORICO> INSCR_RESULTADO_CAD_HISTORICO { get; set; }
    }
}
