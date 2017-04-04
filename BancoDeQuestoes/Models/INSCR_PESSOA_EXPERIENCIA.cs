namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_EXPERIENCIA
    {
        [Key]
        public int ID_EXPERIENCIA { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(70)]
        public string EMPRESA { get; set; }

        [StringLength(50)]
        public string TIPO_VINCULO { get; set; }

        [StringLength(50)]
        public string CARGO_FUNCAO { get; set; }

        [StringLength(4000)]
        public string DESCRICAO_ATIVIDADES { get; set; }

        [StringLength(20)]
        public string PERIODO { get; set; }

        [StringLength(10)]
        public string INICIO { get; set; }

        [StringLength(10)]
        public string TERMINO { get; set; }

        [StringLength(140)]
        public string MOTIVO_DESLIGAMENTO { get; set; }

        public int? ATIVO { get; set; }

        [StringLength(50)]
        public string RAMO_ATIVIDADE { get; set; }

        [StringLength(50)]
        public string PORTE { get; set; }

        [StringLength(50)]
        public string NIVEL { get; set; }

        [StringLength(50)]
        public string REMUNERACAO { get; set; }

        [StringLength(1)]
        public string EMPREGO_ATUAL { get; set; }

        public virtual INSCR_PESSOA INSCR_PESSOA { get; set; }
    }
}
