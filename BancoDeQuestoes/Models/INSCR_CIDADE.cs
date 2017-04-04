namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CIDADE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CidadeId { get; set; }

        [Required]
        [StringLength(38)]
        public string Nome { get; set; }

        public byte? EstadoId { get; set; }

        public bool Capital { get; set; }

        public virtual INSCR_ESTADO INSCR_ESTADO { get; set; }
    }
}
