namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_VINCULO
    {
        [Key]
        [StringLength(10)]
        public string ID_VINCULO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_VINCULO { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
