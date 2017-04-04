namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_RESULTADO
    {
        [Key]
        public int ID_PESSOA_RESULTADO { get; set; }

        public int ID_RESULTADO { get; set; }

        public int ID_CONCURSO { get; set; }

        public int ID_INSCRICAO { get; set; }

        [StringLength(150)]
        public string DESC_IMAGEM { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        [StringLength(50)]
        public string DESC_NOTA01 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA02 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA03 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA04 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA05 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA06 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA07 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA08 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA09 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA10 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA11 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA12 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA13 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA14 { get; set; }

        [StringLength(20)]
        public string DESC_NOTA15 { get; set; }

        [StringLength(20)]
        public string DESC_NOTA16 { get; set; }

        [StringLength(50)]
        public string DESC_CLASSIFICACAO { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        public virtual INSCR_PESSOA_CONCURSO INSCR_PESSOA_CONCURSO { get; set; }

        public virtual INSCR_RESULTADO INSCR_RESULTADO { get; set; }
    }
}
