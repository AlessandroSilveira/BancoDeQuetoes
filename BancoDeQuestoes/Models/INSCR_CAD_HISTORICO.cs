namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CAD_HISTORICO
    {
        [Key]
        public int ID_CAD_HISTORICO { get; set; }

        public int ID_CONCURSO { get; set; }

        public int RG_CAD { get; set; }

        public bool CAD_PG { get; set; }

        [StringLength(50)]
        public string CAD_NOME { get; set; }

        [StringLength(30)]
        public string CAD_NATURAL { get; set; }

        [StringLength(50)]
        public string CAD_MAE { get; set; }

        [StringLength(50)]
        public string CAD_PAI { get; set; }

        [StringLength(14)]
        public string CAD_RG_IE { get; set; }

        [StringLength(10)]
        public string CAD_RG_EST { get; set; }

        [StringLength(1)]
        public string CAD_SEXO { get; set; }

        public int? CAD_ECIVIL { get; set; }

        [StringLength(10)]
        public string CAD_DATANASC { get; set; }

        [StringLength(2)]
        public string CAD_FILHOS { get; set; }

        [StringLength(50)]
        public string CAD_ENDERECO { get; set; }

        [StringLength(20)]
        public string CAD_NUMERO { get; set; }

        [StringLength(100)]
        public string CAD_COMPL { get; set; }

        [StringLength(100)]
        public string CAD_BAIRRO { get; set; }

        [StringLength(8)]
        public string CAD_CEP { get; set; }

        [StringLength(26)]
        public string CAD_CIDADE { get; set; }

        [StringLength(2)]
        public string CAD_UF { get; set; }

        [StringLength(4)]
        public string CAD_DDD { get; set; }

        [StringLength(19)]
        public string CAD_TELEFONE { get; set; }

        [StringLength(4)]
        public string CAD_DDD1 { get; set; }

        [StringLength(19)]
        public string CAD_TELEFONE1 { get; set; }

        [StringLength(4)]
        public string CAD_DDD2 { get; set; }

        [StringLength(19)]
        public string CAD_TELEFONE2 { get; set; }

        [StringLength(4)]
        public string RG_CARGO { get; set; }

        [StringLength(1)]
        public string CAD_DEFICIENTE { get; set; }

        [StringLength(1)]
        public string RG_MAO { get; set; }

        [StringLength(1)]
        public string RG_RAC { get; set; }

        [StringLength(30)]
        public string CAD_DEFICIENCIA { get; set; }

        [StringLength(1)]
        public string CAD_CONDESPECIAL { get; set; }

        [StringLength(150)]
        public string CAD_DEFIDESCRICAO { get; set; }

        [StringLength(11)]
        public string CAD_CPF { get; set; }

        [StringLength(80)]
        public string CAD_EMAIL { get; set; }

        [StringLength(30)]
        public string cad_quest { get; set; }

        public int? CAD_TRANSP { get; set; }

        [StringLength(100)]
        public string CAD_INDICADOR { get; set; }

        [StringLength(10)]
        public string CAD_RA { get; set; }

        [StringLength(1)]
        public string CAD_PROMOCAO { get; set; }

        [StringLength(100)]
        public string CAD_CONVENIO { get; set; }

        [StringLength(1)]
        public string CAD_STATUS { get; set; }

        public DateTime? DAT_CAD { get; set; }

        public int RG_EV { get; set; }

        [StringLength(10)]
        public string CAD_AFRO { get; set; }

        [StringLength(2)]
        public string CAD_FUNC { get; set; }

        [StringLength(10)]
        public string CAD_FUNC_DTINI { get; set; }

        [StringLength(10)]
        public string CAD_FUNC_DTFIM { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO1 { get; set; }

        [StringLength(100)]
        public string CAD_CAMPO2 { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO3 { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO4 { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO5 { get; set; }

        [StringLength(50)]
        public string CAD_CAMPO6 { get; set; }

        public int? RG_BA { get; set; }

        public int ID_INSCRICAO { get; set; }

        public DateTime? DT_ACAO { get; set; }
    }
}
