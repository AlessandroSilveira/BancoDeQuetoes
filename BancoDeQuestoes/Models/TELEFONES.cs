namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TELEFONES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TELEFONE { get; set; }

        [StringLength(15)]
        public string CODIGO_PESSOA { get; set; }

        [StringLength(4)]
        public string COD_TIPO_TELEFONE { get; set; }

        [StringLength(2)]
        public string DDD { get; set; }

        [StringLength(15)]
        public string TELEFONE { get; set; }

        [StringLength(1)]
        public string ACEITA_SMS { get; set; }
    }
}
