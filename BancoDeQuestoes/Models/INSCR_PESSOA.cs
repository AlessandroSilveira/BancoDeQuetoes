namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PESSOA()
        {
            INSCR_PESSOA_CONCURSO = new HashSet<INSCR_PESSOA_CONCURSO>();
            INSCR_PESSOA_CURSO = new HashSet<INSCR_PESSOA_CURSO>();
            INSCR_PESSOA_DEPENDENTE = new HashSet<INSCR_PESSOA_DEPENDENTE>();
            INSCR_PESSOA_EXPERIENCIA = new HashSet<INSCR_PESSOA_EXPERIENCIA>();
            INSCR_PESSOA_FORMACAO = new HashSet<INSCR_PESSOA_FORMACAO>();
            INSCR_PESSOA_IDIOMA = new HashSet<INSCR_PESSOA_IDIOMA>();
            INSCR_PESSOA_INFORMATICA = new HashSet<INSCR_PESSOA_INFORMATICA>();
            INSCR_PESSOA_MINICURRICULO = new HashSet<INSCR_PESSOA_MINICURRICULO>();
        }

        [Key]
        public int ID_PESSOA { get; set; }

        public bool CAD_PG { get; set; }

        [StringLength(50)]
        public string CAD_NOME { get; set; }

        [StringLength(30)]
        public string CAD_NATURAL { get; set; }

        [StringLength(50)]
        public string CAD_MAE { get; set; }

        [StringLength(50)]
        public string CAD_PAI { get; set; }

        [StringLength(14)]
        public string CAD_RG_IE { get; set; }

        [StringLength(10)]
        public string CAD_RG_EST { get; set; }

        [StringLength(1)]
        public string CAD_SEXO { get; set; }

        public int? CAD_ECIVIL { get; set; }

        [StringLength(10)]
        public string CAD_DATANASC { get; set; }

        [StringLength(2)]
        public string CAD_FILHOS { get; set; }

        [StringLength(50)]
        public string CAD_ENDERECO { get; set; }

        [StringLength(20)]
        public string CAD_NUMERO { get; set; }

        [StringLength(100)]
        public string CAD_COMPL { get; set; }

        [StringLength(100)]
        public string CAD_BAIRRO { get; set; }

        [StringLength(8)]
        public string CAD_CEP { get; set; }

        [StringLength(26)]
        public string CAD_CIDADE { get; set; }

        [StringLength(2)]
        public string CAD_UF { get; set; }

        [StringLength(4)]
        public string CAD_DDD { get; set; }

        [StringLength(19)]
        public string CAD_TELEFONE { get; set; }

        [StringLength(4)]
        public string CAD_DDD1 { get; set; }

        [StringLength(19)]
        public string CAD_TELEFONE1 { get; set; }

        [StringLength(4)]
        public string CAD_DDD2 { get; set; }

        [StringLength(19)]
        public string CAD_TELEFONE2 { get; set; }

        [StringLength(4)]
        public string RG_CARGO { get; set; }

        [StringLength(1)]
        public string CAD_DEFICIENTE { get; set; }

        [StringLength(1)]
        public string RG_MAO { get; set; }

        [StringLength(1)]
        public string RG_RAC { get; set; }

        [StringLength(30)]
        public string CAD_DEFICIENCIA { get; set; }

        [StringLength(1)]
        public string CAD_CONDESPECIAL { get; set; }

        [StringLength(150)]
        public string CAD_DEFIDESCRICAO { get; set; }

        [StringLength(11)]
        public string CAD_CPF { get; set; }

        [StringLength(80)]
        public string CAD_EMAIL { get; set; }

        [StringLength(30)]
        public string cad_quest { get; set; }

        public int? CAD_TRANSP { get; set; }

        [StringLength(100)]
        public string CAD_INDICADOR { get; set; }

        [StringLength(10)]
        public string CAD_RA { get; set; }

        [StringLength(1)]
        public string CAD_PROMOCAO { get; set; }

        [StringLength(100)]
        public string CAD_CONVENIO { get; set; }

        [StringLength(1)]
        public string CAD_STATUS { get; set; }

        public DateTime? DAT_CAD { get; set; }

        [StringLength(10)]
        public string CAD_AFRO { get; set; }

        [StringLength(2)]
        public string CAD_FUNC { get; set; }

        [StringLength(10)]
        public string CAD_FUNC_DTINI { get; set; }

        [StringLength(10)]
        public string CAD_FUNC_DTFIM { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO1 { get; set; }

        [StringLength(100)]
        public string CAD_CAMPO2 { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO3 { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO4 { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO5 { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO6 { get; set; }

        [StringLength(4)]
        public string CAD_NACIONALIDADE { get; set; }

        [StringLength(15)]
        public string CAD_MUNICIPIO { get; set; }

        public int? ID_PESSOA_EXT { get; set; }

        [StringLength(4)]
        public string CAD_TIPO_LOGRADOURO { get; set; }

        [StringLength(15)]
        public string CODIGO { get; set; }

        [StringLength(15)]
        public string CAD_NUMERO_PIS { get; set; }

        [StringLength(50)]
        public string CAD_DETALHE_TIPO_DEFICIENCIA { get; set; }

        [StringLength(50)]
        public string CAD_ACOMPANHANTE { get; set; }

        [StringLength(50)]
        public string CAD_NOME_ACOMPANHANTE { get; set; }

        [StringLength(50)]
        public string CAD_CPF_ACOMPANHANTE { get; set; }

        [StringLength(50)]
        public string CAD_NECESSIDADES_ESPECIAIS { get; set; }

        [StringLength(50)]
        public string CAD_OUTROS { get; set; }

        [StringLength(50)]
        public string CAD_OUTRO_CID { get; set; }

        [StringLength(50)]
        public string CAD_DEFICIENCIA_OUTROS { get; set; }

        [StringLength(1)]
        public string CAD_ACEITA_ENVIO_EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_CONCURSO> INSCR_PESSOA_CONCURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_CURSO> INSCR_PESSOA_CURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_DEPENDENTE> INSCR_PESSOA_DEPENDENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_EXPERIENCIA> INSCR_PESSOA_EXPERIENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_FORMACAO> INSCR_PESSOA_FORMACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_IDIOMA> INSCR_PESSOA_IDIOMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_INFORMATICA> INSCR_PESSOA_INFORMATICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PESSOA_MINICURRICULO> INSCR_PESSOA_MINICURRICULO { get; set; }
    }
}
