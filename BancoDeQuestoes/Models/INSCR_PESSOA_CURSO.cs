namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_CURSO
    {
        [Key]
        public int ID_CURSO { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(80)]
        public string NOME_CURSO { get; set; }

        [StringLength(60)]
        public string INSTITUICAO { get; set; }

        [StringLength(8)]
        public string INICIO { get; set; }

        [StringLength(8)]
        public string TERMINO { get; set; }

        [StringLength(10)]
        public string CARGA_HORARIA { get; set; }

        public int? ATIVO { get; set; }

        [StringLength(4)]
        public string ANO { get; set; }

        public string DESCRICAO { get; set; }

        public virtual INSCR_PESSOA INSCR_PESSOA { get; set; }
    }
}
