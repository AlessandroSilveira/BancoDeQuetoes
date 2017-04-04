namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDERH_DEPOIMENTO
    {
        [Key]
        public int ID_DEPOIMENTO { get; set; }

        [StringLength(50)]
        public string DESC_NOME { get; set; }

        [StringLength(150)]
        public string DESC_EMAIL { get; set; }

        [StringLength(50)]
        public string DESC_ASSUNTO { get; set; }

        public string DESC_MENSAGEM { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
