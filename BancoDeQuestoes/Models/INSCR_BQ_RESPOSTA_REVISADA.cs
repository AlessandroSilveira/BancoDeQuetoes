namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BQ_RESPOSTA_REVISADA
    {
        [Key]
        public int ID_RESPOSTA_REVISADA { get; set; }

        public int ID_REVISOR { get; set; }

        public int ID_RESPOSTA { get; set; }

        public int ID_QUESTAO { get; set; }

        public int ID_TOPICO_ATRIBUIDO { get; set; }

        [Required]
        public string DESC_RESPOSTA { get; set; }

        [Required]
        [StringLength(20)]
        public string DESC_CORRECAO { get; set; }

        [Required]
        public string DESC_JUSTIFICATIVA { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        public string DESC_OBSERVACAO_REVISOR { get; set; }

        public string DESC_OBSERVACAO_REVISOR_2 { get; set; }

        public int? NUM_REVISAO { get; set; }

        [StringLength(250)]
        public string DESC_IMAGEM { get; set; }

        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }

        public virtual INSCR_BQ_RESPOSTA INSCR_BQ_RESPOSTA { get; set; }

        public virtual INSCR_BQ_REVISOR INSCR_BQ_REVISOR { get; set; }

        public virtual INSCR_BQ_TOPICO_ATRIBUIDO INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
