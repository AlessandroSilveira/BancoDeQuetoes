namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
        public int ID_MESTRE { get; set; }

        public int? ID_BANCA { get; set; }

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
        public string GRAU_FORMACAO { get; set; }

        [StringLength(50)]
        public string DESC_INSTITUICAO { get; set; }

        public string DESC_FORMACAO_2 { get; set; }

        [StringLength(50)]
        public string GRAU_FORMACAO_2 { get; set; }

        [StringLength(50)]
        public string DESC_INSTITUICAO_2 { get; set; }

        public string DESC_FORMACAO_3 { get; set; }

        [StringLength(50)]
        public string GRAU_FORMACAO_3 { get; set; }

        [StringLength(50)]
        public string DESC_INSTITUICAO_3 { get; set; }

        [StringLength(50)]
        public string DESC_FORMACAO_4 { get; set; }

        [StringLength(50)]
        public string GRAU_FORMACAO_4 { get; set; }

        [StringLength(50)]
        public string DESC_INSTITUICAO_4 { get; set; }

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

        [StringLength(50)]
        public string DESC_BANCO { get; set; }

        [StringLength(50)]
        public string DESC_AGENCIA { get; set; }

        [StringLength(50)]
        public string DESC_TIPO_CONTA { get; set; }

        [StringLength(50)]
        public string DESC_CONTA { get; set; }

        [StringLength(2)]
        public string DESC_FILHOS { get; set; }

        [StringLength(50)]
        public string DESC_PIS { get; set; }

        [StringLength(250)]
        public string DESC_NOME_DEPENDENTE1 { get; set; }

        [StringLength(15)]
        public string DESC_DOCUMENTO_DEPENDENTE1 { get; set; }

        [StringLength(10)]
        public string DESC_DATA_NASCIMENTO_DEPENDENTE1 { get; set; }

        [StringLength(250)]
        public string DESC_NOME_DEPENDENTE2 { get; set; }

        [StringLength(15)]
        public string DESC_DOCUMENTO_DEPENDENTE2 { get; set; }

        [StringLength(10)]
        public string DESC_DATA_NASCIMENTO_DEPENDENTE2 { get; set; }

        [StringLength(15)]
        public string DESC_NOME_DEPENDENTE3 { get; set; }

        [StringLength(15)]
        public string DESC_DOCUMENTO_DEPENDENTE3 { get; set; }

        [StringLength(10)]
        public string DESC_DATA_NASCIMENTO_DEPENDENTE3 { get; set; }

        [StringLength(3)]
        public string CURRICULO { get; set; }

        [StringLength(3)]
        public string DIPLOMA { get; set; }

        [StringLength(1)]
        public string DESC_ACEITE { get; set; }

        [StringLength(50)]
        public string ENTREGOU_COPIA_DIPLOMA_GRADUACAO { get; set; }

        [StringLength(50)]
        public string DIPLOMA_GRADUACAO_AUTENTICADO { get; set; }

        [StringLength(50)]
        public string NUMERO_COPIAS_DIPLOMA_AUTENTICADO { get; set; }

        [StringLength(50)]
        public string ENTREGOU_COPIA_DIPLOMA_POSGRADUACAO { get; set; }

        [StringLength(50)]
        public string DIPLOMA_POSGRADUACAO_AUTENTICADO { get; set; }

        [StringLength(50)]
        public string NUMERO_COPIAS_DIPLOMA_POSGRADUACAO_AUTENTICADO { get; set; }

        [StringLength(50)]
        public string ENTREGOU_COPIA_DIPLOMA_MESTRADO { get; set; }

        [StringLength(50)]
        public string DIPLOMA_MESTRADO_AUTENTICADO { get; set; }

        [StringLength(50)]
        public string NUMERO_COPIAS_DIPLOMA_MESTRADO_AUTENTICADO { get; set; }

        [StringLength(50)]
        public string ENTREGOU_COPIA_DIPLOMA_DOUTORADO { get; set; }

        [StringLength(50)]
        public string DIPLOMA_DOUTORADO_AUTENTICADO { get; set; }

        [StringLength(50)]
        public string NUMERO_COPIAS_DIPLOMA_DOUTORADO_AUTENTICADO { get; set; }

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
