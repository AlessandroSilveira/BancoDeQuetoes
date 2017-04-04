namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CANDIDATO_SEBRAE
    {
        [Key]
        public int RG_CAD { get; set; }

        public int ID_CONCURSO { get; set; }

        public int ID_RESULTADO { get; set; }

        [Required]
        [StringLength(250)]
        public string CAD_NOME { get; set; }

        [Required]
        [StringLength(11)]
        public string CAD_CPF { get; set; }

        [Required]
        [StringLength(3)]
        public string RG_CARGO { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        public virtual INSCR_RESULTADO INSCR_RESULTADO { get; set; }
    }
}
