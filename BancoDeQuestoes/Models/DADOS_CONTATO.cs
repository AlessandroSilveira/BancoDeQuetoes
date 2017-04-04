namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DADOS_CONTATO
    {
        [Key]
        [StringLength(15)]
        public string CODIGO_PESSOA { get; set; }

        [Required]
        [StringLength(60)]
        public string E_MAIL { get; set; }

        [Required]
        [StringLength(15)]
        public string CEP { get; set; }

        [Required]
        [StringLength(4)]
        public string TIPO_DE_LOGRADOURO { get; set; }

        [Required]
        [StringLength(40)]
        public string ENDERECO { get; set; }

        [Required]
        [StringLength(10)]
        public string NUMERO { get; set; }

        [StringLength(40)]
        public string COMPLEMENTO { get; set; }

        [Required]
        [StringLength(4)]
        public string ESTADO { get; set; }

        [Required]
        [StringLength(15)]
        public string CIDADE { get; set; }

        [Required]
        [StringLength(40)]
        public string BAIRRO { get; set; }
    }
}
