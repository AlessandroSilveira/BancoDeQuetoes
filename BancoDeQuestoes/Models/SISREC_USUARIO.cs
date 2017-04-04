namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SISREC_USUARIO
    {
        [Key]
        public int ID_USUARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_USUARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_LOGIN { get; set; }

        [Required]
        [StringLength(10)]
        public string DESC_SENHA { get; set; }

        [Required]
        [StringLength(10)]
        public string DESC_TIPO { get; set; }

        public int DESC_ATIVO { get; set; }
    }
}
