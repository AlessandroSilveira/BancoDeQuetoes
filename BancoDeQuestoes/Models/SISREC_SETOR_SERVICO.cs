namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SISREC_SETOR_SERVICO
    {
        [Key]
        public int ID_SETOR_SERVICO { get; set; }

        public int ID_DEPARTAMENTO { get; set; }

        public int ID_ORGAO { get; set; }

        [Required]
        [StringLength(150)]
        public string DESC_SETOR_SERVICO { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public virtual SISREC_DEPARTAMENTO SISREC_DEPARTAMENTO { get; set; }

        public virtual SISREC_ORGAO SISREC_ORGAO { get; set; }
    }
}
