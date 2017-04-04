namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA_ESCOLA_RH
    {
        [Key]
        public int ID_PROVA_ESCOLA_RH { get; set; }

        public int? ID_PROVA_ESCOLA { get; set; }

        public int? ID_PAGAMENTO { get; set; }

        [StringLength(250)]
        public string DESC_NOME { get; set; }

        [StringLength(50)]
        public string DESC_CARGO { get; set; }

        public string DESC_ENDERECO { get; set; }

        [StringLength(2)]
        public string DESC_DDD { get; set; }

        [StringLength(10)]
        public string DESC_TELEFONE { get; set; }

        [StringLength(50)]
        public string DESC_EMAIL { get; set; }

        [StringLength(11)]
        public string DESC_CPF { get; set; }

        [StringLength(20)]
        public string DESC_PIS { get; set; }

        [StringLength(50)]
        public string DESC_RG { get; set; }

        [StringLength(10)]
        public string DESC_BANCO { get; set; }

        [StringLength(50)]
        public string DESC_BANCO_NUMERO { get; set; }

        [StringLength(50)]
        public string DESC_BANCO_AGENCIA { get; set; }

        [StringLength(50)]
        public string DESC_BANCO_CONTA { get; set; }

        [StringLength(50)]
        public string DESC_BANCO_TIPO { get; set; }

        [StringLength(2)]
        public string NUM_ATIVO { get; set; }

        public virtual INSCR_PROVA_ESCOLA INSCR_PROVA_ESCOLA { get; set; }

        public virtual INSCR_PROVA_PAGAMENTO INSCR_PROVA_PAGAMENTO { get; set; }
    }
}
