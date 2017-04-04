namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CAD_DOCUMENTO
    {
        [Key]
        public int ID_CAD_DOCUMENTO { get; set; }

        public int ID_DOCUMENTO { get; set; }

        public int ID_CONCURSO { get; set; }

        public int RG_CAD { get; set; }

        [Required]
        [StringLength(150)]
        public string DESC_NOME { get; set; }

        [Required]
        [StringLength(150)]
        public string DESC_ARQUIVO { get; set; }

        public DateTime DT_INCLUSAO { get; set; }

        [StringLength(50)]
        public string DESC_DECISAO { get; set; }

        [StringLength(250)]
        public string DESC_OBSERVACAO { get; set; }

        public DateTime? DT_RESPOSTA { get; set; }

        public int ID_ADMIN { get; set; }

        [StringLength(1)]
        public string DESC_PUBLICADO { get; set; }

        public virtual INSCR_ADMIN INSCR_ADMIN { get; set; }

        public virtual INSCR_CAD INSCR_CAD { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        public virtual INSCR_DOCUMENTO INSCR_DOCUMENTO { get; set; }
    }
}
