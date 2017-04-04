namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CID
    {
        [Key]
        public int ID_CID { get; set; }

        [StringLength(20)]
        public string CODIGO_CID { get; set; }

        public string DESC_CID { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }
    }
}
