namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_CONVITE_REVISOR
    {
        [Key]
        public int ID_CONVITE_REVISOR { get; set; }

        public int ID_CONVITE { get; set; }

        public int ID_REVISOR { get; set; }

        public int? ID_QUESTAO { get; set; }

        public int NUM_QUESTAO { get; set; }

        public int DESC_ACEITE { get; set; }

        [StringLength(50)]
        public string TIPO_PAGAMENTO { get; set; }

        [StringLength(50)]
        public string DESC_VALOR { get; set; }

        [StringLength(50)]
        public string DATA_ACEITE { get; set; }

        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }

        public virtual INSCR_BQ_REVISOR INSCR_BQ_REVISOR { get; set; }
    }
}
