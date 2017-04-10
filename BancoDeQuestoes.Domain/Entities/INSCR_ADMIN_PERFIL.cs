namespace BancoDeQuestoes.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class INSCR_ADMIN_PERFIL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ADMIN_PERFIL { get; set; }

        public int ID_ADMIN { get; set; }

        public int ID_PERFIL { get; set; }

        public int? ID_CONCURSO { get; set; }

        [StringLength(50)]
        public string DESC_VARIAVEL { get; set; }

        public virtual INSCR_ADMIN INSCR_ADMIN { get; set; }
        

        //public virtual INSCR_PERFIL INSCR_PERFIL { get; set; }
    }
}
