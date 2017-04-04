namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CRONOGRAMA
    {
        [Key]
        public int ID_CRONOGRAMA { get; set; }

        public int ID_CONCURSO { get; set; }

        [StringLength(300)]
        public string DESC_ITEM_CRONOGRAMA { get; set; }

        public DateTime? DESC_DATA_INICIAL { get; set; }

        public DateTime? DESC_DATA_FINAL { get; set; }

        [StringLength(50)]
        public string DESC_DATA_ITEM_CRONOGRAMA { get; set; }

        public int NUM_ORDEM { get; set; }

        [StringLength(50)]
        public string DESC_CLIENTE { get; set; }

        [StringLength(1)]
        public string DESC_STATUS { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }
    }
}
