namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_IDIOMA
    {
        [Key]
        public int ID_IDIOMA { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(45)]
        public string NOME_IDIOMA { get; set; }

        [StringLength(11)]
        public string CATEGORIA { get; set; }

        public int? NIVEL { get; set; }

        public int? ATIVO { get; set; }

        public virtual INSCR_PESSOA INSCR_PESSOA { get; set; }
    }
}
