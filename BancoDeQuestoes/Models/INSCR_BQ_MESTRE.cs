using System.ComponentModel;

namespace BancoDeQuestoes.Models
{
	using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

	public partial class INSCR_BQ_MESTRE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_MESTRE()
        {
            INSCR_BQ_CONVITE_MESTRE = new HashSet<INSCR_BQ_CONVITE_MESTRE>();
            INSCR_BQ_CONVITE_REVISAO_MESTRE = new HashSet<INSCR_BQ_CONVITE_REVISAO_MESTRE>();
            INSCR_BQ_TOPICO_ATRIBUIDO = new HashSet<INSCR_BQ_TOPICO_ATRIBUIDO>();
        }

        [Key]
		[Required]
        public int ID_MESTRE { get; set; }

		[Required]
		[DisplayName("Banca")]
		public int? ID_BANCA { get; set; }

        [StringLength(500)]
		[Required]
		[DisplayName("Nome")]
		public string DESC_NOME { get; set; }

        [StringLength(8)]
		[Required]
		[DisplayName("CEP")]
		public string DESC_CEP { get; set; }
		[Required]
		[DisplayName("Endereço")]
		public string DESC_ENDERECO { get; set; }

        [StringLength(100)]
		[DisplayName("Complemento")]
		public string DESC_COMPLEMENTO { get; set; }

        [StringLength(5)]
		[Required]
		[DisplayName("Número")]
		public string DESC_NUMERO { get; set; }

        [StringLength(100)]
		[Required]
		[DisplayName("Bairro")]
		public string DESC_BAIRRO { get; set; }

        [StringLength(50)]
		[Required]
		[DisplayName("Cidade")]
		public string DESC_CIDADE { get; set; }

        [StringLength(2)]
		[Required]
		[DisplayName("UF")]
		public string DESC_ESTADO { get; set; }

		[Required]
		[DisplayName("Formação")]
		public string DESC_FORMACAO { get; set; }

        [StringLength(50)]
		[Required]
		[DisplayName("Grau de Formação")]
		public string GRAU_FORMACAO { get; set; }

        [StringLength(50)]
		[Required]
		[DisplayName("Instituição")]
		public string DESC_INSTITUICAO { get; set; }

		[DisplayName("Segunda Formação")]
		public string DESC_FORMACAO_2 { get; set; }

        [StringLength(50)]
		[DisplayName("Grau de Formação")]
		public string GRAU_FORMACAO_2 { get; set; }

        [StringLength(50)]
		[DisplayName("Instituição")]
		public string DESC_INSTITUICAO_2 { get; set; }

		[DisplayName("Terceira Formação")]
		public string DESC_FORMACAO_3 { get; set; }

        [StringLength(50)]
		[DisplayName("Grau de Formação")]
		public string GRAU_FORMACAO_3 { get; set; }

        [StringLength(50)]
		[DisplayName("Instituição")]
		public string DESC_INSTITUICAO_3 { get; set; }

        [StringLength(50)]
		[DisplayName("Quarta Formação")]
		public string DESC_FORMACAO_4 { get; set; }

        [StringLength(50)]
		[DisplayName("Grau de Formação")]
		public string GRAU_FORMACAO_4 { get; set; }

        [StringLength(50)]
		[DisplayName("Instituição")]
		public string DESC_INSTITUICAO_4 { get; set; }

        [StringLength(11)]
		[DisplayName("CPF")]
		[Required]
		public string DESC_CPF { get; set; }

        [StringLength(150)]
		[DisplayName("Email")]
		[Required]
		public string DESC_EMAIL { get; set; }

		[StringLength(150)]
		[DisplayName("Email alternativo")]
		[Required]
        public string DESC_EMAIL_2 { get; set; }

        [StringLength(2)]
		[DisplayName("DDD")]
		[Required]
		public string DESC_DDD { get; set; }

        [StringLength(8)]
		[DisplayName("Telefone")]
		[Required]
		public string DESC_TELEFONE { get; set; }

        
		[StringLength(2)]
		[DisplayName("DDD")]
		[Required]
		public string DESC_DDD_CEL { get; set; }

        [StringLength(9)]
		[DisplayName("Celular")]
		[Required]
		public string DESC_CELULAR { get; set; }

        [StringLength(8)]
		[DisplayName("Senha")]
		[Required]
		public string DESC_SENHA { get; set; }

        [StringLength(50)]
		[DisplayName("Área")]
		public string DESC_DISCIPLINA { get; set; }

        [StringLength(1)]
		[DisplayName("Ativo")]
		public string DESC_ATIVO { get; set; }

        [StringLength(50)]
		[DisplayName("Banco")]
		[Required]
		public string DESC_BANCO { get; set; }

        [StringLength(50)]
		[DisplayName("Agência")]
		[Required]
		public string DESC_AGENCIA { get; set; }

        [StringLength(50)]
		[DisplayName("Tipo de Conta")]
		[Required]
		public string DESC_TIPO_CONTA { get; set; }

        [StringLength(50)]
		[DisplayName("Conta")]
		[Required]
		public string DESC_CONTA { get; set; }

        [StringLength(2)]
		[DisplayName("Filhos")]
		public string DESC_FILHOS { get; set; }

        [StringLength(50)]
		[DisplayName("PIS")]
		public string DESC_PIS { get; set; }

        [StringLength(250)]
		[DisplayName("Nome Dependente")]
		public string DESC_NOME_DEPENDENTE1 { get; set; }

        [StringLength(15)]
		[DisplayName("Documento")]
		public string DESC_DOCUMENTO_DEPENDENTE1 { get; set; }

        [StringLength(10)]
		[DisplayName("Data de Nascimento do Dependente")]
		public string DESC_DATA_NASCIMENTO_DEPENDENTE1 { get; set; }

        [StringLength(250)]
		[DisplayName("Nome Dependente")]
		public string DESC_NOME_DEPENDENTE2 { get; set; }

        [StringLength(15)]
		[DisplayName("Documento")]
		public string DESC_DOCUMENTO_DEPENDENTE2 { get; set; }

        [StringLength(10)]
		[DisplayName("Data de Nascimento do Dependente")]
		public string DESC_DATA_NASCIMENTO_DEPENDENTE2 { get; set; }

        [StringLength(15)]
		[DisplayName("Nome Dependente")]
		public string DESC_NOME_DEPENDENTE3 { get; set; }

        [StringLength(15)]
		[DisplayName("Documento")]
		public string DESC_DOCUMENTO_DEPENDENTE3 { get; set; }

        [StringLength(10)]
		[DisplayName("Data de Nascimento do Dependente")]
		public string DESC_DATA_NASCIMENTO_DEPENDENTE3 { get; set; }

        [StringLength(3)]
		[DisplayName("Currículo")]
		public string CURRICULO { get; set; }

        [StringLength(3)]
		[DisplayName("Diploma")]
		public string DIPLOMA { get; set; }

        [StringLength(1)]
		[DisplayName("Aceite")]
		public string DESC_ACEITE { get; set; }

        [StringLength(50)]
		[DisplayName("Entregou a cópia do diploma de graduação")]
		public string ENTREGOU_COPIA_DIPLOMA_GRADUACAO { get; set; }

        [StringLength(50)]
		[DisplayName("Diploma está Autenticado?")]
		public string DIPLOMA_GRADUACAO_AUTENTICADO { get; set; }

        [StringLength(50)]
		[DisplayName("Número de Cópias Autenticadas:")]
        public string NUMERO_COPIAS_DIPLOMA_AUTENTICADO { get; set; }

        [StringLength(50)]
		[DisplayName("Entregou a cópia do diploma de Pós-graduação")]
		public string ENTREGOU_COPIA_DIPLOMA_POSGRADUACAO { get; set; }

        [StringLength(50)]
		[DisplayName("Diploma está Autenticado?")]
		public string DIPLOMA_POSGRADUACAO_AUTENTICADO { get; set; }

        [StringLength(50)]
		[DisplayName("Número de Cópias Autenticadas:")]
		public string NUMERO_COPIAS_DIPLOMA_POSGRADUACAO_AUTENTICADO { get; set; }

        [StringLength(50)]
		[DisplayName("Entregou a cópia do diploma de Mestrado")]
		public string ENTREGOU_COPIA_DIPLOMA_MESTRADO { get; set; }

        [StringLength(50)]
		[DisplayName("Diploma está Autenticado?")]
		public string DIPLOMA_MESTRADO_AUTENTICADO { get; set; }

        [StringLength(50)]
		[DisplayName("Número de Cópias Autenticadas:")]
		public string NUMERO_COPIAS_DIPLOMA_MESTRADO_AUTENTICADO { get; set; }

        [StringLength(50)]
		[DisplayName("Entregou a cópia do diploma de Mestrado")]
		public string ENTREGOU_COPIA_DIPLOMA_DOUTORADO { get; set; }

        [StringLength(50)]
		[DisplayName("Diploma está Autenticado?")]
		public string DIPLOMA_DOUTORADO_AUTENTICADO { get; set; }

        [StringLength(50)]
		[DisplayName("Número de Cópias Autenticadas:")]
		public string NUMERO_COPIAS_DIPLOMA_DOUTORADO_AUTENTICADO { get; set; }

		[DisplayName("Mini-currículo")]
		public string MINICURRICULO { get; set; }

        public virtual INSCR_BQ_BANCA INSCR_BQ_BANCA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_CONVITE_MESTRE> INSCR_BQ_CONVITE_MESTRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_CONVITE_REVISAO_MESTRE> INSCR_BQ_CONVITE_REVISAO_MESTRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
