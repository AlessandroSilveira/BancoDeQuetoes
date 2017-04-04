namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_INFORMATICA
    {
        [Key]
        public int ID_INFORMATICA { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(50)]
        public string DESC_CONHECIMENTO { get; set; }

        [StringLength(50)]
        public string DESC_NIVEL { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public virtual INSCR_PESSOA INSCR_PESSOA { get; set; }
    }
}
