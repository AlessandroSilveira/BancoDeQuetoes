namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CAD_COMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONCURSO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RG_CAD { get; set; }

        [StringLength(50)]
        public string CAD_FATOR { get; set; }

        [StringLength(50)]
        public string CAD_DOADOR { get; set; }

        [StringLength(50)]
        public string CAD_CONTA_CORRENTE { get; set; }

        [StringLength(50)]
        public string CAD_AGENCIA { get; set; }

        [StringLength(50)]
        public string CAD_PARENTESCO { get; set; }

        [StringLength(250)]
        public string CAD_NOME_PARENTESCO { get; set; }

        [StringLength(50)]
        public string CAD_LOTACAO_PARENTESCO { get; set; }

        [StringLength(50)]
        public string CAD_TELEFONE_IES { get; set; }

        [StringLength(50)]
        public string CAD_HORARIO_AULA_IES { get; set; }

        [StringLength(50)]
        public string CAD_COLACAO { get; set; }

        [StringLength(50)]
        public string CAD_NOME_AGENCIA { get; set; }

        [StringLength(50)]
        public string CAD_GRAU_PARENTESCO { get; set; }

        [StringLength(50)]
        public string CAD_PERIODO_ANO_ATUAL { get; set; }

        [StringLength(10)]
        public string CAD_DATA_CADASTRO { get; set; }

        public virtual INSCR_CAD INSCR_CAD { get; set; }
    }
}
