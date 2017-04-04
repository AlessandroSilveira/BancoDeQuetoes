namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_NIVEL_ESCOLAR
    {
        [Key]
        [StringLength(4)]
        public string ID_NIVEL { get; set; }

        [StringLength(50)]
        public string DESC_NIVEL { get; set; }
    }
}
