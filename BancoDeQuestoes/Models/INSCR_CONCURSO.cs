namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CONCURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_CONCURSO()
        {
            INSCR_ADMIN_PERFIL = new HashSet<INSCR_ADMIN_PERFIL>();
            INSCR_CAD = new HashSet<INSCR_CAD>();
            INSCR_CAD_DOCUMENTO = new HashSet<INSCR_CAD_DOCUMENTO>();
            INSCR_CANDIDATO_SEBRAE = new HashSet<INSCR_CANDIDATO_SEBRAE>();
            INSCR_CARGO = new HashSet<INSCR_CARGO>();
            INSCR_CRONOGRAMA = new HashSet<INSCR_CRONOGRAMA>();
            INSCR_DOCUMENTO = new HashSet<INSCR_DOCUMENTO>();
            INSCR_EV = new HashSet<INSCR_EV>();
            INSCR_LISTA1 = new HashSet<INSCR_LISTA1>();
            INSCR_LOCAL = new HashSet<INSCR_LOCAL>();
            INSCR_PESSOA_CONVOCACAO = new HashSet<INSCR_PESSOA_CONVOCACAO>();
            INSCR_PESSOA_RESPOSTA_ISENCAO = new HashSet<INSCR_PESSOA_RESPOSTA_ISENCAO>();
            INSCR_PESSOA_RESULTADO = new HashSet<INSCR_PESSOA_RESULTADO>();
            INSCR_PESSOA_RESULTADO_OFICIAL = new HashSet<INSCR_PESSOA_RESULTADO_OFICIAL>();
            INSCR_PROVA_PROCESSO = new HashSet<INSCR_PROVA_PROCESSO>();
            INSCR_PUBLICACAO = new HashSet<INSCR_PUBLICACAO>();
            INSCR_RESULTADO = new HashSet<INSCR_RESULTADO>();
            INSCR_TEMA_REDACAO = new HashSet<INSCR_TEMA_REDACAO>();
            INSCR_USUARIO = new HashSet<INSCR_USUARIO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONCURSO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESC_NOME { get; set; }

        [StringLength(50)]
        public string DESC_EMPRESA { get; set; }

        [StringLength(1)]
        public string DESC_PUBLICADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_ADMIN_PERFIL> INSCR_ADMIN_PERFIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CAD> INSCR_CAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CAD_DOCUMENTO> INSCR_CAD_DOCUMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CANDIDATO_SEBRAE> INSCR_CANDIDATO_SEBRAE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CARGO> INSCR_CARGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_CRONOGRAMA> INSCR_CRONOGRAMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_DOCUMENTO> INSCR_DOCUMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_EV> INSCR_EV { get; set; }

        public virtual INSCR_INSTBOLETO INSCR_INSTBOLETO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_LISTA1> INSCR_LISTA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_LOCAL> INSCR_LOCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_CONVOCACAO> INSCR_PESSOA_CONVOCACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_RESPOSTA_ISENCAO> INSCR_PESSOA_RESPOSTA_ISENCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_RESULTADO> INSCR_PESSOA_RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_RESULTADO_OFICIAL> INSCR_PESSOA_RESULTADO_OFICIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PROCESSO> INSCR_PROVA_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PUBLICACAO> INSCR_PUBLICACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_RESULTADO> INSCR_RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_TEMA_REDACAO> INSCR_TEMA_REDACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_USUARIO> INSCR_USUARIO { get; set; }
    }
}
