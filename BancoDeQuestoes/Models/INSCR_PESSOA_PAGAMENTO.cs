namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_PAGAMENTO
    {
        [Key]
        public int ID_PESSOA_PAGAMENTO { get; set; }

        public int ID_CONCURSO { get; set; }

        public int ID_INSCRICAO { get; set; }

        public double NUM_VALOR { get; set; }

        [Required]
        [StringLength(20)]
        public string DESC_STATUS { get; set; }

        public DateTime DT_CRIADO { get; set; }

        public DateTime DT_VENCIMENTO { get; set; }
    }
}
