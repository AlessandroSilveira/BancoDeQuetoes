namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_TELEFONE
    {
        [Key]
        public int ID_PESSOA_TELEFONE { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(15)]
        public string DESC_CPF { get; set; }

        [StringLength(4)]
        public string DESC_TIPO_TELEFONE { get; set; }

        [StringLength(2)]
        public string DESC_DDD { get; set; }

        [StringLength(15)]
        public string DESC_TELEFONE { get; set; }

        [StringLength(1)]
        public string DESC_ACEITA_SMS { get; set; }

        [StringLength(15)]
        public string CODIGO_PESSOA { get; set; }
    }
}
