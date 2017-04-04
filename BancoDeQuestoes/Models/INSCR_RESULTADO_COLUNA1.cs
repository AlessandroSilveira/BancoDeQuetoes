namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_RESULTADO_COLUNA1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RESULTADO_COLUNA { get; set; }

        public int ID_RESULTADO { get; set; }

        public int NUM_ORDEM { get; set; }

        [Required]
        [StringLength(150)]
        public string DESC_COLUNA { get; set; }

        [StringLength(4000)]
        public string DESC_LEGENDA { get; set; }

        public virtual INSCR_RESULTADO INSCR_RESULTADO { get; set; }
    }
}
