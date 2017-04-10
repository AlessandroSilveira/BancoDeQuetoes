namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_QUESTAO_RECICLADA_COMP
    {
        [Key]
        public int ID_QUESTAO_RECICLADA_COMP { get; set; }

        public int ID_QUESTAO { get; set; }

        public int ID_ADMIN { get; set; }

        public DateTime DATA_RECICLAGEM { get; set; }

        public int? ID_QUESTAO_REVISADA { get; set; }
    }
}
