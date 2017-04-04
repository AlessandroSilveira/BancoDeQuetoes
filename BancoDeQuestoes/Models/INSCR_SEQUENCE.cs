namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_SEQUENCE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SEQUENCE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_SEQUENCE { get; set; }

        public int NUM_SEQUENCE { get; set; }
    }
}
