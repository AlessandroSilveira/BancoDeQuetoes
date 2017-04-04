namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CURSO
    {
        [Key]
        [StringLength(15)]
        public string ID_CURSO { get; set; }

        [StringLength(250)]
        public string DESC_CURSO { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
