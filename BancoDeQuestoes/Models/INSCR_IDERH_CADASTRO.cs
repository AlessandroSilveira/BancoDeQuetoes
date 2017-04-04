namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDERH_CADASTRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_IDERH_CADASTRO()
        {
            INSCR_IDERH_CAD_PROJETO = new HashSet<INSCR_IDERH_CAD_PROJETO>();
        }

        [Key]
        public int ID_CAD { get; set; }

        [StringLength(250)]
        public string CAD_NOME { get; set; }

        [StringLength(50)]
        public string CAD_NATUAL { get; set; }

        [StringLength(1)]
        public string CAD_SEXO { get; set; }

        [StringLength(11)]
        public string CAD_CPF { get; set; }

        [StringLength(250)]
        public string CAD_PAI { get; set; }

        [StringLength(250)]
        public string CAD_MAE { get; set; }

        [StringLength(15)]
        public string CAD_RG { get; set; }

        [StringLength(5)]
        public string CAD_ORG_EMIS { get; set; }

        [StringLength(10)]
        public string CAD_DATA_NASCIMENTO { get; set; }

        [StringLength(10)]
        public string CAD_CEP { get; set; }

        [StringLength(50)]
        public string CAD_ENDEREÇO { get; set; }

        [StringLength(5)]
        public string CAD_NUMERO { get; set; }

        [StringLength(50)]
        public string CAD_COMPLEMENTO { get; set; }

        [StringLength(30)]
        public string CAD_BAIRRO { get; set; }

        [StringLength(30)]
        public string CAD_CIDADE { get; set; }

        [StringLength(2)]
        public string CAD_ESTADO { get; set; }

        [StringLength(2)]
        public string CAD_DDD { get; set; }

        [StringLength(9)]
        public string CAD_TELEFONE { get; set; }

        [StringLength(2)]
        public string CAD_DDD_CELULAR { get; set; }

        [StringLength(9)]
        public string CAD_CELULAR { get; set; }

        [StringLength(2)]
        public string CAD_DDD_COMERCIAL { get; set; }

        [StringLength(9)]
        public string CAD_COMERCIAL { get; set; }

        [StringLength(80)]
        public string CAD_EMAIL { get; set; }

        [StringLength(1)]
        public string CAD_DEFICIENTE { get; set; }

        [StringLength(1)]
        public string CAD_RENDA { get; set; }

        [StringLength(250)]
        public string CAD_ESCOLA { get; set; }

        [StringLength(250)]
        public string CAD_ENDERECO_ESCOLA { get; set; }

        [StringLength(50)]
        public string CAD_DIRETORA { get; set; }

        [StringLength(2)]
        public string CAD_DDD_ESCOLA { get; set; }

        [StringLength(9)]
        public string CAD_TELEFONE_ESCOLA { get; set; }

        [StringLength(50)]
        public string CAD_EMAIL_ESCOLA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_IDERH_CAD_PROJETO> INSCR_IDERH_CAD_PROJETO { get; set; }
    }
}
