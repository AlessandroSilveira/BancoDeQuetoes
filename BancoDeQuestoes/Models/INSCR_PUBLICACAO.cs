namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PUBLICACAO
    {
        public int ID_CONCURSO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PUBLICACAO { get; set; }

        [Required]
        [StringLength(1250)]
        public string DESC_MENSAGEM { get; set; }

        [StringLength(150)]
        public string DESC_DATA_PUB { get; set; }

        [StringLength(250)]
        public string DESC_LINK { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public int NUM_ORDEM { get; set; }

        public DateTime DT_PUB { get; set; }

        public int ID_USUARIO { get; set; }

        public DateTime? DT_PUBLICACAO_INICIO { get; set; }

        public DateTime? DT_PUBLICACAO_TERMINO { get; set; }

        [StringLength(50)]
        public string DESC_TARGET { get; set; }

        public int? NUM_ORDEM_OFICIAL { get; set; }

        [StringLength(50)]
        public string DESC_CLIENTE { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        public virtual INSCR_USUARIO INSCR_USUARIO { get; set; }
    }
}
