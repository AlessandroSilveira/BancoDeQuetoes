namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SISREC_CARGOS
    {
        [Key]
        public int ID_CARGO { get; set; }

        public int ID_ORGAO { get; set; }

        public int CODIGO_CARGO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_CARGO { get; set; }

        [Required]
        [StringLength(5)]
        public string TIPO_CARGO { get; set; }

        [StringLength(5)]
        public string DESC_CBO { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public virtual SISREC_ORGAO SISREC_ORGAO { get; set; }
    }
}
