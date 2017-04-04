namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_COORDENADOR_ACESSO
    {
        [Key]
        public int ID_COORDENADOR_ACESSO { get; set; }

        public int? ID_COORDENADOR { get; set; }

        public DateTime? DT_ACESSO { get; set; }

        public virtual INSCR_COORDENADOR INSCR_COORDENADOR { get; set; }
    }
}
