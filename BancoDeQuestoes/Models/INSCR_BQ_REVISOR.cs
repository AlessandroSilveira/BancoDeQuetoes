namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_REVISOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_REVISOR()
        {
            INSCR_BQ_CONVITE_REVISOR = new HashSet<INSCR_BQ_CONVITE_REVISOR>();
            INSCR_BQ_QUESTAO_RECICLAR_REVISOR = new HashSet<INSCR_BQ_QUESTAO_RECICLAR_REVISOR>();
            INSCR_BQ_QUESTAO_REVISADA = new HashSet<INSCR_BQ_QUESTAO_REVISADA>();
            INSCR_BQ_QUESTAO_REVISOR = new HashSet<INSCR_BQ_QUESTAO_REVISOR>();
            INSCR_BQ_RESPOSTA_REVISADA = new HashSet<INSCR_BQ_RESPOSTA_REVISADA>();
        }

        [Key]
        public int ID_REVISOR { get; set; }

        [StringLength(500)]
        public string DESC_NOME { get; set; }

        [StringLength(8)]
        public string DESC_CEP { get; set; }

        public string DESC_ENDERECO { get; set; }

        [StringLength(100)]
        public string DESC_COMPLEMENTO { get; set; }

        [StringLength(5)]
        public string DESC_NUMERO { get; set; }

        [StringLength(100)]
        public string DESC_BAIRRO { get; set; }

        [StringLength(50)]
        public string DESC_CIDADE { get; set; }

        [StringLength(2)]
        public string DESC_ESTADO { get; set; }

        public string DESC_FORMACAO { get; set; }

        [StringLength(50)]
        public string DESC_INSTITUICAO { get; set; }

        public string DESC_FORMACAO_2 { get; set; }

        [StringLength(50)]
        public string DESC_INSTITUICAO_2 { get; set; }

        public string DESC_FORMACAO_3 { get; set; }

        [StringLength(50)]
        public string DESC_INSTITUICAO_3 { get; set; }

        [StringLength(11)]
        public string DESC_CPF { get; set; }

        [StringLength(150)]
        public string DESC_EMAIL { get; set; }

        [StringLength(150)]
        public string DESC_EMAIL_2 { get; set; }

        [StringLength(2)]
        public string DESC_DDD { get; set; }

        [StringLength(8)]
        public string DESC_TELEFONE { get; set; }

        [StringLength(2)]
        public string DESC_DDD_CEL { get; set; }

        [StringLength(9)]
        public string DESC_CELULAR { get; set; }

        [StringLength(8)]
        public string DESC_SENHA { get; set; }

        [StringLength(50)]
        public string DESC_DISCIPLINA { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_CONVITE_REVISOR> INSCR_BQ_CONVITE_REVISOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_RECICLAR_REVISOR> INSCR_BQ_QUESTAO_RECICLAR_REVISOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_REVISADA> INSCR_BQ_QUESTAO_REVISADA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_REVISOR> INSCR_BQ_QUESTAO_REVISOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
    }
}
