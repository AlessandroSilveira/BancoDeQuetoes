namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_LOCAL_CARGO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_LOCAL_CARGO { get; set; }

        public int ID_CONCURSO { get; set; }

        public int ID_LOCAL { get; set; }

        [Required]
        [StringLength(4)]
        public string RG_CARGO { get; set; }

        public virtual INSCR_CARGO INSCR_CARGO { get; set; }

        public virtual INSCR_LOCAL INSCR_LOCAL { get; set; }
    }
}
