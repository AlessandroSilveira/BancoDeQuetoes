namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_CHAT_INTERACAO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CHAT_INTERACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CHAT { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "ntext")]
        public string DESC_INTERACAO { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DT_INTERACAO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string DESC_ADMIN { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUM_LIDO_CLIENTE { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUM_LIDO_ATENDENTE { get; set; }
    }
}
