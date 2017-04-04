namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_FORMACAO
    {
        [Key]
        public int ID_FORMACAO { get; set; }

        public int ID_PESSOA { get; set; }

        public int? FORMACAO { get; set; }

        public int? STATUS_FORMACAO { get; set; }

        public DateTime? DATA_PROVAVEL { get; set; }

        [StringLength(80)]
        public string INSTITUICAO { get; set; }

        [StringLength(60)]
        public string CURSO { get; set; }

        [StringLength(20)]
        public string SEMESTRE { get; set; }

        public int? ATIVO { get; set; }

        [StringLength(8)]
        public string INICIO { get; set; }

        [StringLength(8)]
        public string TERMINO { get; set; }

        [StringLength(8)]
        public string CARGA_HORARIA { get; set; }

        [StringLength(40)]
        public string REGISTO_ACADEMICO { get; set; }

        [StringLength(10)]
        public string DATA_INICIAL { get; set; }

        [StringLength(10)]
        public string DATA_FINAL { get; set; }

        public int? DURACAO_CURSO { get; set; }

        public int? PERIODO_AULA { get; set; }

        public int? SEMESTRE_ATUAL { get; set; }

        [StringLength(10)]
        public string USADO_ESTAGIO { get; set; }

        [StringLength(10)]
        public string MODALIDADE_CURSO { get; set; }

        [StringLength(4)]
        public string DESC_FORMACAO { get; set; }

        public virtual INSCR_PESSOA INSCR_PESSOA { get; set; }
    }
}
