namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_MUNICIPIOS_IBGE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(50)]
        public string DESC_MUNICIPIO { get; set; }

        [StringLength(2)]
        public string DESC_UF { get; set; }
    }
}
