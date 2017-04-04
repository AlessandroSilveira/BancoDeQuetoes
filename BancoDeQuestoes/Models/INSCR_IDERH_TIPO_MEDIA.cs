namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDERH_TIPO_MEDIA
    {
        [Key]
        public int ID_MEDIA { get; set; }

        [StringLength(50)]
        public string DESC_TIPO_MEDIA { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
