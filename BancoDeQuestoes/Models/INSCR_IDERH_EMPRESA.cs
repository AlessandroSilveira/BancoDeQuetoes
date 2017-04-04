namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDERH_EMPRESA
    {
        [Key]
        public int ID_EMPRESA { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_EMPRESA { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
