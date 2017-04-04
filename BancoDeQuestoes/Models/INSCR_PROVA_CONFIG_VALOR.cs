namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_CONFIG_VALOR
    {
        [Key]
        public int ID_PROVA_CONFIG { get; set; }

        public int? ID_CONFIG { get; set; }

        public int? ID_PROVA { get; set; }

        public double? DESC_VALOR { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public virtual INSCR_PROVA INSCR_PROVA { get; set; }

        public virtual INSCR_PROVA_CONFIG INSCR_PROVA_CONFIG { get; set; }
    }
}
