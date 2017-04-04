namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DADOS_PESSOAIS
    {
        [Key]
        [StringLength(15)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(60)]
        public string NOME { get; set; }

        [Required]
        [StringLength(4)]
        public string NACIONALIDADE { get; set; }

        [Required]
        [StringLength(4)]
        public string NATURALIDADE_UF { get; set; }

        [Required]
        [StringLength(15)]
        public string MUNICIPIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA_DE_NASCIMENTO { get; set; }

        [Required]
        [StringLength(4)]
        public string SEXO { get; set; }

        [Required]
        [StringLength(4)]
        public string ESTADO_CIVIL { get; set; }

        [Required]
        [StringLength(20)]
        public string RG { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA_EXPEDICAO_RG { get; set; }

        [Required]
        [StringLength(30)]
        public string ORGAO_EXPEDITOR_RG { get; set; }

        [Required]
        [StringLength(2)]
        public string UF_RG { get; set; }

        [Required]
        [StringLength(4)]
        public string NECESSIDADES_ESPECIAIS { get; set; }
    }
}
