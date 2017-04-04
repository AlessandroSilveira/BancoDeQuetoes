namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CONVITE_REVISAO_MESTRE
    {
        [Key]
        public int ID_CONVITE_REVISAO_MESTRE { get; set; }

        public int? ID_CONVITE { get; set; }

        public int? ID_MESTRE { get; set; }

        public int? ID_TOPICO_ATRIBUICAO { get; set; }

        [StringLength(10)]
        public string DATA_ACEITE { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ACEITE { get; set; }
    }
}
