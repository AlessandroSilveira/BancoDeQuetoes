namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_CONVOCACAO
    {
        [Key]
        public int ID_PESSOA_CONVOCACAO { get; set; }

        public int ID_PROVA_PROCESSO_LOCAL { get; set; }

        public int ID_CONCURSO { get; set; }

        public int ID_INSCRICAO { get; set; }

        [StringLength(50)]
        public string DESC_PERIODO { get; set; }

        [StringLength(50)]
        public string DESC_ORDEM { get; set; }

        [StringLength(50)]
        public string DESC_CARTEIRA { get; set; }

        [StringLength(50)]
        public string DESC_ANDAR { get; set; }

        [StringLength(50)]
        public string DESC_SALA { get; set; }

        [StringLength(50)]
        public string DESC_HORA_ENTRADA { get; set; }

        [StringLength(50)]
        public string DESC_HORA_FECHA { get; set; }

        [StringLength(50)]
        public string DESC_HORA_PORTAO { get; set; }

        [StringLength(10)]
        public string DESC_LOCAL_NUMERO { get; set; }

        [StringLength(150)]
        public string DESC_LOCAL_ESCOLA { get; set; }

        [StringLength(150)]
        public string DESC_LOCAL_ENDERECO { get; set; }

        [StringLength(50)]
        public string DESC_LOCAL_BAIRRO { get; set; }

        [StringLength(9)]
        public string DESC_LOCAL_CEP { get; set; }

        [StringLength(50)]
        public string DESC_LOCAL_CIDADE { get; set; }

        [StringLength(2)]
        public string DESC_LOCAL_UF { get; set; }

        [StringLength(50)]
        public string DESC_DATA_PROVA { get; set; }

        [StringLength(4000)]
        public string DESC_OBSERVACAO { get; set; }

        [StringLength(1)]
        public string DESC_HABILITADO { get; set; }

        [StringLength(1)]
        public string DESC_AUSENTE { get; set; }

        public int? ID_SALA { get; set; }

        [StringLength(50)]
        public string DESC_DEFICIENTE { get; set; }

        public int? NUM_ATIVO { get; set; }

        public int? NUM_CLASSIFICACAO { get; set; }

        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        public double? NUM_NOTA { get; set; }

        [StringLength(400)]
        public string DESC_ARQUIVO { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        public virtual INSCR_PESSOA_CONCURSO INSCR_PESSOA_CONCURSO { get; set; }

        public virtual INSCR_PROVA_PROCESSO_LOCAL INSCR_PROVA_PROCESSO_LOCAL { get; set; }
    }
}
