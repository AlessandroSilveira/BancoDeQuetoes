namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_QUESTAO_PROJETO
    {
        [Key]
        public int ID_QUESTAO_PROJETO { get; set; }

        public int ID_QUESTAO_REVISADA { get; set; }

        public int ID_PROJETO { get; set; }

        public virtual INSCR_BQ_PROJETO INSCR_BQ_PROJETO { get; set; }

        public virtual INSCR_BQ_QUESTAO_REVISADA INSCR_BQ_QUESTAO_REVISADA { get; set; }
    }
}
