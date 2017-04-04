namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_RG_CAD
    {
        [Key]
        public int RG_CAD { get; set; }

        public DateTime? NUM_ADD { get; set; }
    }
}
