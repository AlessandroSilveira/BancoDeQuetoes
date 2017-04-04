namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_DEFICIENCIA
    {
        [Key]
        public int ID_DEFICIENCIA { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME_DEFICIENCIA { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
