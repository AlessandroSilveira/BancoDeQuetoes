namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_LISTA1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_LISTA1 { get; set; }

        public int ID_CONCURSO { get; set; }

        [Required]
        [StringLength(250)]
        public string DESC_LISTA1 { get; set; }

        [StringLength(150)]
        public string DESC_LISTA1_1 { get; set; }

        [StringLength(150)]
        public string DESC_LISTA1_2 { get; set; }

        [StringLength(150)]
        public string DESC_LISTA1_3 { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }
    }
}
