namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_OCORRENCIA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_OCORRENCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONCURSO { get; set; }

        public int RG_CAD { get; set; }

        public DateTime DT_OCORRENCIA { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_TIPO { get; set; }

        [StringLength(50)]
        public string DESC_QUESTAO { get; set; }

        [StringLength(150)]
        public string DESC_STATUS { get; set; }

        public DateTime? DT_RESPOSTA { get; set; }

        [StringLength(4000)]
        public string DESC_OBSERVACAO { get; set; }

        [Column(TypeName = "ntext")]
        public string DESC_ARGUMENTACAO { get; set; }

        [StringLength(1050)]
        public string DESC_ARQUIVO1 { get; set; }

        [StringLength(1050)]
        public string DESC_ARQUIVO2 { get; set; }

        [StringLength(1050)]
        public string DESC_ARQUIVO3 { get; set; }

        [StringLength(150)]
        public string DESC_GABARITO { get; set; }

        [StringLength(150)]
        public string DESC_DECISAO { get; set; }

        [StringLength(1)]
        public string DESC_PUBLICADO { get; set; }

        public int ID_ADMIN { get; set; }

        [StringLength(11)]
        public string DESC_CPF { get; set; }

        [StringLength(50)]
        public string DESC_TITULAR { get; set; }

        [StringLength(50)]
        public string DESC_BANCO { get; set; }

        [StringLength(50)]
        public string DESC_AGENCIA { get; set; }

        [StringLength(50)]
        public string DESC_CONTA { get; set; }

        public virtual INSCR_ADMIN INSCR_ADMIN { get; set; }
    }
}
