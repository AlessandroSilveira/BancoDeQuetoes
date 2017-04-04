namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_CONCURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PESSOA_CONCURSO()
        {
            INSCR_PESSOA_CONVOCACAO = new HashSet<INSCR_PESSOA_CONVOCACAO>();
            INSCR_PESSOA_RESPOSTA_ISENCAO = new HashSet<INSCR_PESSOA_RESPOSTA_ISENCAO>();
            INSCR_PESSOA_RESULTADO = new HashSet<INSCR_PESSOA_RESULTADO>();
            INSCR_PESSOA_RESULTADO_OFICIAL = new HashSet<INSCR_PESSOA_RESULTADO_OFICIAL>();
        }

        [Key]
        public int ID_INSCRICAO { get; set; }

        public int ID_CONCURSO { get; set; }

        public int ID_PESSOA { get; set; }

        [Required]
        [StringLength(15)]
        public string CAD_INSCRICAO { get; set; }

        public bool CAD_PG { get; set; }

        [StringLength(4)]
        public string RG_CARGO { get; set; }

        [StringLength(1)]
        public string CAD_STATUS { get; set; }

        public DateTime? DAT_CAD { get; set; }

        public int RG_EV { get; set; }

        [StringLength(10)]
        public string CAD_AFRO { get; set; }

        public int? RG_BA { get; set; }

        [StringLength(50)]
        public string CAD_NIS { get; set; }

        [StringLength(50)]
        public string CAD_CID { get; set; }

        [StringLength(400)]
        public string CAD_LAUDO { get; set; }

        [StringLength(50)]
        public string CAD_STATUS_INSCRICAO { get; set; }

        [StringLength(50)]
        public string CAD_LOCAL_TRABALHO { get; set; }

        [StringLength(50)]
        public string CAD_MUNICIPIO_TRABALHO { get; set; }

        [StringLength(150)]
        public string CAD_CONDICAO_ESPECIAL { get; set; }

        [StringLength(150)]
        public string CAD_MAE { get; set; }

        public int? ID_LOCAL { get; set; }

        public int? ID_PROVA_LOCAL { get; set; }

        [StringLength(50)]
        public string CODIGO_PROCESSO_SELETIVO { get; set; }

        [StringLength(50)]
        public string CAD_HORARIO_PROVA { get; set; }

        [StringLength(50)]
        public string CAD_NECESSIDADE_ESPECIAL { get; set; }

        public virtual INSCR_CARGO INSCR_CARGO { get; set; }

        public virtual INSCR_PESSOA INSCR_PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_CONVOCACAO> INSCR_PESSOA_CONVOCACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_RESPOSTA_ISENCAO> INSCR_PESSOA_RESPOSTA_ISENCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_RESULTADO> INSCR_PESSOA_RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_RESULTADO_OFICIAL> INSCR_PESSOA_RESULTADO_OFICIAL { get; set; }
    }
}
