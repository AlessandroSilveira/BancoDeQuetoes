namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_CONVITE_MESTRE
    {
        [Key]
        public int ID_CONVITE_MESTRE { get; set; }

        public int ID_CONVITE { get; set; }

        public int ID_MESTRE { get; set; }

        public int ID_TOPICO_ATRIBUIDO { get; set; }

        public int NUM_QUESTAO { get; set; }

        public int DESC_ACEITE { get; set; }

        [StringLength(50)]
        public string TIPO_PAGAMENTO { get; set; }

        [StringLength(50)]
        public string DESC_VALOR { get; set; }

        [StringLength(50)]
        public string DATA_ACEITE { get; set; }

        public virtual INSCR_BQ_MESTRE INSCR_BQ_MESTRE { get; set; }

        public virtual INSCR_BQ_TOPICO_ATRIBUIDO INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
