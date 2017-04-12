namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_STATUS
    {
        [Key]
        public int ID_STATUS { get; set; }

        public int? ID_DESC_STATUS { get; set; }

        [Required]
        [StringLength(150)]
        public string DESC_STATUS { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
