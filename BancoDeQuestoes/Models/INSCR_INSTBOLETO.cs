namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_INSTBOLETO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CONCURSO { get; set; }

        [StringLength(50)]
        public string IDCONV { get; set; }

        public int? DiasBoleto { get; set; }

        [StringLength(4)]
        public string versao { get; set; }

        public string msgloja { get; set; }

        [StringLength(3)]
        public string moeda { get; set; }

        [StringLength(50)]
        public string convClasse { get; set; }

        [StringLength(2)]
        public string tpPagamento { get; set; }

        [StringLength(150)]
        public string Link { get; set; }

        [StringLength(50)]
        public string venc { get; set; }

        public string demonstra1 { get; set; }

        public string demonstra2 { get; set; }

        public string demonstra3 { get; set; }

        public string demonstra4 { get; set; }

        public string demonstra5 { get; set; }

        public string instrucao1 { get; set; }

        public string instrucao2 { get; set; }

        public string instrucao3 { get; set; }

        public string instrucao4 { get; set; }

        public string instrucao5 { get; set; }

        [StringLength(50)]
        public string local { get; set; }

        [StringLength(10)]
        public string preConv { get; set; }

        [StringLength(50)]
        public string agencia { get; set; }

        [StringLength(50)]
        public string conta { get; set; }

        [StringLength(50)]
        public string DESC_CEDENTE { get; set; }

        [StringLength(20)]
        public string DESC_CNPJ { get; set; }

        [StringLength(50)]
        public string DESC_ENDERECO_CEDENTE { get; set; }

        [StringLength(50)]
        public string DESC_CIDADE_CEDENTE { get; set; }

        [StringLength(20)]
        public string DESC_CONTRATO { get; set; }

        public int ID_BANCO_BAIXA { get; set; }

        public virtual INSCR_BANCO_BAIXA INSCR_BANCO_BAIXA { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }
    }
}
