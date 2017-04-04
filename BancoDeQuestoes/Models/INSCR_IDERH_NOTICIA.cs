namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDERH_NOTICIA
    {
        [Key]
        public int ID_NOTICIA { get; set; }

        [StringLength(150)]
        public string DESC_TITULO { get; set; }

        public string DESC_CORPO { get; set; }

        [StringLength(10)]
        public string DESC_TIPO_MEDIA { get; set; }

        [StringLength(150)]
        public string DESC_LINK_MEDIA { get; set; }

        public DateTime? DESC_DATA_INICIO_PUB { get; set; }

        public DateTime? DESC_DATA_FIM_PUB { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [StringLength(50)]
        public string DESC_EMPRESA { get; set; }
    }
}
