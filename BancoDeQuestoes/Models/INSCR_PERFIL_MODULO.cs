namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PERFIL_MODULO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PERFIL_MODULO { get; set; }

        public int ID_PERFIL { get; set; }

        public int ID_MODULO { get; set; }

        public virtual INSCR_MODULO INSCR_MODULO { get; set; }

        public virtual INSCR_PERFIL INSCR_PERFIL { get; set; }
    }
}
