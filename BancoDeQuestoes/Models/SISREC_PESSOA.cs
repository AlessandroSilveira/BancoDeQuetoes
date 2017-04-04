namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SISREC_PESSOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SISREC_PESSOA()
        {
            SISREC_DADOS_COMPLEMENTARES = new HashSet<SISREC_DADOS_COMPLEMENTARES>();
        }

        [Key]
        public int ID_PESSOA { get; set; }

        [StringLength(200)]
        public string DESC_NOME { get; set; }

        [Required]
        [StringLength(11)]
        public string DESC_CPF { get; set; }

        [StringLength(50)]
        public string DESC_CATEGORIA { get; set; }

        [StringLength(1)]
        public string DESC_SEXO { get; set; }

        [StringLength(1)]
        public string DESC_ESTADO_CIVIL { get; set; }

        public DateTime? DESC_DATA_NASCIMENTO { get; set; }

        [StringLength(200)]
        public string DESC_NOME_MAE { get; set; }

        [StringLength(200)]
        public string DESC_NOME_PAI { get; set; }

        [StringLength(1)]
        public string DESC_NECESSIDADES_ESPECIAIS { get; set; }

        [StringLength(1)]
        public string DESC_INVALIDEZ { get; set; }

        [StringLength(50)]
        public string DESC_NACIONALIDADE { get; set; }

        [StringLength(50)]
        public string DESC_UF_NASCIMENTO { get; set; }

        [StringLength(100)]
        public string DESC_NATURALIDADE { get; set; }

        [StringLength(50)]
        public string DESC_SITUACAO_NATURALIZACAO { get; set; }

        [StringLength(50)]
        public string DESC_RACA { get; set; }

        [StringLength(50)]
        public string DESC_ESCOLARIDADE { get; set; }

        [StringLength(20)]
        public string DESC_RG { get; set; }

        [StringLength(10)]
        public string DESC_ORGAO_EMISSOR { get; set; }

        [StringLength(2)]
        public string DESC_UF_RG { get; set; }

        public DateTime? DESC_DATA_EMISSAO { get; set; }

        [StringLength(10)]
        public string DESC_CTPS { get; set; }

        [StringLength(50)]
        public string DESC_SERIE_CTPS { get; set; }

        [StringLength(2)]
        public string DESC_UF_CTPS { get; set; }

        public DateTime? DESC_DATA_EMISSAO_CPTS { get; set; }

        [StringLength(50)]
        public string DESC_LOCAL_EXPEDICAO_CTPS { get; set; }

        [StringLength(50)]
        public string DESC_TITULO_ELEITOR { get; set; }

        [StringLength(10)]
        public string DESC_ZONA_ELEITORAL { get; set; }

        [StringLength(20)]
        public string DESC_SECAO { get; set; }

        [StringLength(2)]
        public string DESC_UF_TITULO_ELEITOR { get; set; }

        [StringLength(50)]
        public string DESC_CARTEIRA_PROFISSIONAL { get; set; }

        [StringLength(2)]
        public string DESC_UF_CARTEIRA_PROFISSIONAL { get; set; }

        [StringLength(50)]
        public string DESC_NUMERO_CARTEIRA_PROFISSIONAL { get; set; }

        [StringLength(50)]
        public string DESC_CONSELHO_CARTEIRA_PROFISSIONAL { get; set; }

        [StringLength(10)]
        public string DESC_LIVRO_CERTIDAO_NASCIMENTO { get; set; }

        [StringLength(10)]
        public string DESC_FOLHA_CERTIDAO_NaSCIMENTO { get; set; }

        [StringLength(10)]
        public string DESC_NUMERO_CERTICAO_NASCIMENTO { get; set; }

        [StringLength(10)]
        public string DESC_MATRICULA_CERTIDAO_NASCIMENTO { get; set; }

        [StringLength(20)]
        public string DESC_CNH { get; set; }

        [StringLength(15)]
        public string DESC_PIS_PASEP { get; set; }

        [StringLength(20)]
        public string DESC_RESERVISTA { get; set; }

        [StringLength(8)]
        public string DESC_CEP { get; set; }

        [StringLength(250)]
        public string DESC_ENDERECO { get; set; }

        [StringLength(30)]
        public string DESC_BAIRRO { get; set; }

        [StringLength(20)]
        public string DESC_NUMERO { get; set; }

        [StringLength(100)]
        public string DESC_COMPLEMENTO { get; set; }

        [StringLength(20)]
        public string DESC_CIDADE { get; set; }

        [StringLength(2)]
        public string DESC_UF { get; set; }

        [StringLength(2)]
        public string DESC_DDD_RESIDENCIAL { get; set; }

        [StringLength(9)]
        public string DESC_TELEFONE_RESIDENCIAL { get; set; }

        [StringLength(2)]
        public string DESC_DDD_CELULAR { get; set; }

        [StringLength(9)]
        public string DESC_TELEFONE_CELULAR { get; set; }

        [StringLength(2)]
        public string DESC_DDD_COMERCIAL { get; set; }

        [StringLength(9)]
        public string DESC_TELEFONE_COMERCIAL { get; set; }

        [StringLength(150)]
        public string DESC_EMAIL { get; set; }

        [StringLength(500)]
        public string DESC_OBSERCACAO { get; set; }

        [StringLength(10)]
        public string DESC_MATRICULA { get; set; }

        [StringLength(50)]
        public string DESC_CARGO_OCUPADO { get; set; }

        [StringLength(50)]
        public string DESC_LOCAL_TRABALHO { get; set; }

        [StringLength(50)]
        public string DESC_ENTE_FEDERATIVO { get; set; }

        public DateTime? DESC_DATA_RECADASTRO { get; set; }

        public int? DESC_USUARIO { get; set; }

        public int? DESC_CADASTRO_COMPLETO { get; set; }

        [StringLength(250)]
        public string DESC_IMAGEM { get; set; }

        [StringLength(50)]
        public string DESC_JORNADA_TRABALHO { get; set; }

        [StringLength(10)]
        public string DESC_DATA_ESCALA { get; set; }

        [StringLength(5)]
        public string DESC_ORGAO { get; set; }

        [StringLength(5)]
        public string DESC_DEPARTAMENTO { get; set; }

        [StringLength(5)]
        public string DESC_SETOR_SERVICO { get; set; }

        [StringLength(50)]
        public string DESC_DESCRICAO_ENTE_FEDERATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SISREC_DADOS_COMPLEMENTARES> SISREC_DADOS_COMPLEMENTARES { get; set; }
    }
}
