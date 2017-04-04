namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PAGAMENTO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONCURSO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RG_CAD { get; set; }

        public double NUM_VALOR { get; set; }

        public DateTime DT_VENCIMENTO { get; set; }

        [Required]
        [StringLength(20)]
        public string DESC_STATUS { get; set; }

        public DateTime DT_CRIADO { get; set; }

        public virtual INSCR_CAD INSCR_CAD { get; set; }
    }
}
