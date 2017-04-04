namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_MINICURRICULO
    {
        [Key]
        public int ID_MINICURRICULO { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(2500)]
        public string DESC_MINICURICULO { get; set; }

        public int? DESC_ATIVO { get; set; }

        public virtual INSCR_PESSOA INSCR_PESSOA { get; set; }
    }
}
