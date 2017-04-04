namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_NACIONALIDADE
    {
        [Key]
        [StringLength(4)]
        public string ID_NACIONALIDADE { get; set; }

        [StringLength(50)]
        public string DESC_NACIONALIDADE { get; set; }
    }
}
