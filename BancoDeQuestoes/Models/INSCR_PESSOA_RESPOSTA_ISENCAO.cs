namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_RESPOSTA_ISENCAO
    {
        [Key]
        public int ID_PESSOA_RESPOSTA_ISENCAO { get; set; }

        public int ID_CONCURSO { get; set; }

        public int ID_INSCRICAO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        [Required]
        public string DESC_RESPOSTA { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        public virtual INSCR_PESSOA_CONCURSO INSCR_PESSOA_CONCURSO { get; set; }
    }
}
