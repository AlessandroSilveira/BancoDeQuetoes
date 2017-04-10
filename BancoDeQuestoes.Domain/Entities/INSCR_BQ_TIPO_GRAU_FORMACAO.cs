namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_TIPO_GRAU_FORMACAO
    {
        [Key]
        public int ID_TIPO_GRAU_FORMACAO { get; set; }

        [StringLength(50)]
        public string DESC_TIPO_GRAU_FORMACAO { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
