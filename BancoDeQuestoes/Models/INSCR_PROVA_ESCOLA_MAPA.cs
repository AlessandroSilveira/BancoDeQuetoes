namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_ESCOLA_MAPA
    {
        [Key]
        public int ID_PROVA_ESCOLA_MAPA { get; set; }

        public int? ID_SALA { get; set; }

        public int? ID_ESCOLA { get; set; }

        public int? NUM_QUANT_CARTEIRA { get; set; }

        public virtual INSCR_ESCOLA INSCR_ESCOLA { get; set; }

        public virtual INSCR_ESCOLA_SALA INSCR_ESCOLA_SALA { get; set; }
    }
}
