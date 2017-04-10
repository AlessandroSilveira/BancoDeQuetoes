using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_QUESTAO_REVISOR
    {
        [Key]
        public int ID_QUESTAO_REVISOR { get; set; }

        public int ID_REVISOR { get; set; }

        public int ID_QUESTAO { get; set; }

        [StringLength(10)]
        public string DESC_DATA_ENTREGA { get; set; }

        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        [StringLength(10)]
        public string DESC_VALOR { get; set; }

        [StringLength(1)]
        public string DESC_REVISAO_1 { get; set; }

        [StringLength(1)]
        public string DESC_REVISAO_2 { get; set; }

        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }

        public virtual Revisor Revisor { get; set; }
    }
}
