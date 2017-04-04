namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_PROCESSO_CARGO
    {
        [Key]
        public int ID_PROVA_PROCESSO_CARGO { get; set; }

        public int ID_PROVA_PROCESSO { get; set; }

        public int ID_CONCURSO { get; set; }

        [Required]
        [StringLength(4)]
        public string RG_CARGO { get; set; }

        public int NUM_VAGAS { get; set; }

        public virtual INSCR_CARGO INSCR_CARGO { get; set; }

        public virtual INSCR_PROVA_PROCESSO INSCR_PROVA_PROCESSO { get; set; }
    }
}
