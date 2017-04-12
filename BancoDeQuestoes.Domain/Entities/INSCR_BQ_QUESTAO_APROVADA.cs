namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_QUESTAO_APROVADA
    {
        [Key]
        public int ID_QUESTAO_APROVADA { get; set; }

        public int ID_QUESTAO { get; set; }

        [StringLength(50)]
        public string PROJETO_1 { get; set; }

        [StringLength(50)]
        public string PROJETO_2 { get; set; }

        [StringLength(50)]
        public string PROJETO_3 { get; set; }
    }
}
