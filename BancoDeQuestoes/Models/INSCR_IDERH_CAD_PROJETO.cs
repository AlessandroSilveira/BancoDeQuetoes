namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_IDERH_CAD_PROJETO
    {
        [Key]
        public int ID_CAD_PROJETO { get; set; }

        public int ID_CAD { get; set; }

        public int ID_IDERH_PROJETOS { get; set; }

        public virtual INSCR_IDERH_CADASTRO INSCR_IDERH_CADASTRO { get; set; }

        public virtual INSCR_IDERH_PROJETOS INSCR_IDERH_PROJETOS { get; set; }
    }
}
