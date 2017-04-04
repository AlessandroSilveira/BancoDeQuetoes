namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DADOS_ESTAGIO
    {
        [Key]
        public int ID_DADOS_ESTAGIO { get; set; }

        [Required]
        [StringLength(15)]
        public string CODIGO_PESSOA { get; set; }

        [StringLength(15)]
        public string CURSO { get; set; }

        [StringLength(100)]
        public string INSTITUICAO { get; set; }

        public int? NIVEL_ESCOLAR { get; set; }

        [StringLength(10)]
        public string REGISTRO_ACADEMICO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_TERMINO { get; set; }

        public int? DURACAO_CURSO { get; set; }

        public int? PERIODO_AULA { get; set; }

        [StringLength(1)]
        public string MODALIDADE_CURSO { get; set; }
    }
}
