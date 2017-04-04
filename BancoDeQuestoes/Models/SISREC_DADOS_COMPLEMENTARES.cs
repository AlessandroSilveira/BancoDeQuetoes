namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SISREC_DADOS_COMPLEMENTARES
    {
        [Key]
        public int ID_SISREC_DADOS_COMPLEMENTARES { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(250)]
        public string DESC_TITULO_CURSO { get; set; }

        [StringLength(250)]
        public string DESC_INSTITUICAO { get; set; }

        [StringLength(50)]
        public string DESC_DURACAO { get; set; }

        [StringLength(10)]
        public string DESC_MES_ANO_CONCLUSAO { get; set; }

        public virtual SISREC_PESSOA SISREC_PESSOA { get; set; }
    }
}
