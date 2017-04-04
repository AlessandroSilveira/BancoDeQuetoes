namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDERH_DICAS
    {
        [Key]
        public int ID_DICA { get; set; }

        [StringLength(50)]
        public string DESC_TITULO_DICA { get; set; }

        public string DESC_CORPO_DICA { get; set; }

        public DateTime? DESC_DATA_INICIO_PUB { get; set; }

        public DateTime? DESC_DATA_FIM_PUB { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        [StringLength(50)]
        public string DESC_EMPRESA { get; set; }
    }
}
