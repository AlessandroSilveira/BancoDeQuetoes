namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_EV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONCURSO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RG_EV { get; set; }

        [StringLength(150)]
        public string EV_TITULO { get; set; }

        public string EV_TEXTO_INICIAL { get; set; }

        public DateTime? EV_ABERTURA { get; set; }

        public DateTime? EV_TERMINO { get; set; }

        [StringLength(1)]
        public string EV_STATUS { get; set; }

        public DateTime? EV_VENCIMENTO_BOLETO { get; set; }

        [StringLength(80)]
        public string EV_EMAIL { get; set; }

        public int? EV_ISENCAO { get; set; }

        public DateTime? EV_ABERTURA_ISENCAO { get; set; }

        public DateTime? EV_TERMINO_ISENCAO { get; set; }

        public DateTime? EV_ABERTURA_ALTERACAO { get; set; }

        public DateTime? EV_TERMINO_ALTERACAO { get; set; }

        [StringLength(250)]
        public string EV_LINK { get; set; }

        [StringLength(250)]
        public string EV_GRUPO { get; set; }

        public string EV_DESC_CARGOS { get; set; }

        public int? EV_OPCAO_AFRO { get; set; }

        public int? EV_NUMERO_CID { get; set; }

        [StringLength(1)]
        public string DESC_PUBLICADO { get; set; }

        [StringLength(150)]
        public string EV_IMAGEM { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }
    }
}
