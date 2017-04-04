namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_COORDENADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_COORDENADOR()
        {
            INSCR_COORDENADOR_ACESSO = new HashSet<INSCR_COORDENADOR_ACESSO>();
            INSCR_COORDENADOR_ESCOLA = new HashSet<INSCR_COORDENADOR_ESCOLA>();
            INSCR_PROVA_CIDADE = new HashSet<INSCR_PROVA_CIDADE>();
            INSCR_PROVA_ESCOLA = new HashSet<INSCR_PROVA_ESCOLA>();
            INSCR_PROVA_PAGAMENTO = new HashSet<INSCR_PROVA_PAGAMENTO>();
        }

        [Key]
        public int ID_COORDENADOR { get; set; }

        public string DESC_NOME { get; set; }

        [StringLength(250)]
        public string DESC_ENDERECO { get; set; }

        [StringLength(250)]
        public string DESC_COMPLEMENTO { get; set; }

        [StringLength(10)]
        public string DESC_NUMERO { get; set; }

        [StringLength(10)]
        public string DESC_CEP { get; set; }

        [StringLength(50)]
        public string DESC_BAIRRO { get; set; }

        [StringLength(50)]
        public string DESC_CIDADE { get; set; }

        [StringLength(2)]
        public string DESC_UF { get; set; }

        [StringLength(2)]
        public string DESC_DDD { get; set; }

        [StringLength(9)]
        public string DESC_TELEFONE { get; set; }

        [StringLength(2)]
        public string DESC_DDD1 { get; set; }

        [StringLength(9)]
        public string DESC_TELEFONE1 { get; set; }

        [StringLength(50)]
        public string DESC_EMAIL { get; set; }

        [StringLength(11)]
        public string DESC_CPF { get; set; }

        [StringLength(20)]
        public string DESC_PIS { get; set; }

        [StringLength(10)]
        public string DESC_RG { get; set; }

        [StringLength(5)]
        public string DESC_RG_EST { get; set; }

        [StringLength(50)]
        public string DESC_BANCO { get; set; }

        [StringLength(50)]
        public string DESC_AGENCIA { get; set; }

        [StringLength(50)]
        public string DESC_CONTA { get; set; }

        [StringLength(50)]
        public string DESC_SENHA { get; set; }

        [StringLength(1)]
        public string NUM_ATIVO { get; set; }

        public DateTime? DT_INCLUSAO { get; set; }

        [StringLength(1)]
        public string DESC_ACEITO { get; set; }

        [StringLength(50)]
        public string DESC_LOGIN { get; set; }

        [StringLength(1)]
        public string DESC_CONTRATO_ACEITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_COORDENADOR_ACESSO> INSCR_COORDENADOR_ACESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_COORDENADOR_ESCOLA> INSCR_COORDENADOR_ESCOLA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_CIDADE> INSCR_PROVA_CIDADE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_ESCOLA> INSCR_PROVA_ESCOLA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_PAGAMENTO> INSCR_PROVA_PAGAMENTO { get; set; }
    }
}
