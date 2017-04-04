namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_COORDENADOR_ESCOLA
    {
        [Key]
        public int ID_COORDENADOR_ESCOLA { get; set; }

        public int ID_ESCOLA { get; set; }

        public int ID_COORDENADOR { get; set; }

        public int? NUM_ATIVO { get; set; }

        public virtual INSCR_COORDENADOR INSCR_COORDENADOR { get; set; }

        public virtual INSCR_ESCOLA INSCR_ESCOLA { get; set; }
    }
}
