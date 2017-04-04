namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDIOMA
    {
        [Key]
        [StringLength(20)]
        public string ID_IDIOMA { get; set; }

        [StringLength(20)]
        public string DESC_IDIOMA { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
