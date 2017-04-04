namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PESSOA_DEPENDENTE
    {
        [Key]
        public int ID_DEPENDENTE { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(60)]
        public string DESC_NOME { get; set; }

        [StringLength(1)]
        public string DESC_NAO_CONSTA_BRANCO { get; set; }

        [StringLength(11)]
        public string DESC_CPF { get; set; }

        [StringLength(4)]
        public string DESC_GRAU_PARENTESCO { get; set; }

        [StringLength(4)]
        public string DESC_ESTADO_CIVIL { get; set; }

        [StringLength(4)]
        public string DESC_SEXO { get; set; }

        [StringLength(4)]
        public string DESC_NACIONALIDADE { get; set; }

        [StringLength(60)]
        public string DESC_MAE_DEPENDENTE { get; set; }

        public DateTime? DESC_DATA_NASCIMENTO { get; set; }

        [StringLength(15)]
        public string DESC_CARTAO_SUS { get; set; }

        [StringLength(16)]
        public string DESC_NASCIDO_VIVO { get; set; }

        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public virtual INSCR_PESSOA INSCR_PESSOA { get; set; }
    }
}
