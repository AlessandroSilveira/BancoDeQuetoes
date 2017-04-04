namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_USUARIO()
        {
            INSCR_PUBLICACAO = new HashSet<INSCR_PUBLICACAO>();
        }

        public int ID_CONCURSO { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        [StringLength(10)]
        public string senha { get; set; }

        [StringLength(50)]
        public string dataencerra { get; set; }

        [StringLength(50)]
        public string dataabre { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_USUARIO { get; set; }

        public virtual INSCR_CONCURSO INSCR_CONCURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PUBLICACAO> INSCR_PUBLICACAO { get; set; }
    }
}
