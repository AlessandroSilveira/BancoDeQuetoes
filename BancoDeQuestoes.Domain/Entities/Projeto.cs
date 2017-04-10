using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Domain.Entities
{
    public  class Projeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projeto()
        {
            INSCR_BQ_QUESTAO_PROJETO = new HashSet<INSCR_BQ_QUESTAO_PROJETO>();
            INSCR_BQ_TOP_DISC_CARGO = new HashSet<INSCR_BQ_TOP_DISC_CARGO>();
            INSCR_BQ_TOPICO_ATRIBUIDO = new HashSet<INSCR_BQ_TOPICO_ATRIBUIDO>();
        }

        [Key]
        public int ProjetoId { get; set; }

        [Required]
        [DisplayName("Código do Projeto")]
        public int? CodigoProjeto { get; set; }

        [StringLength(150)]
        [Required]
        [DisplayName("Descrição do Projeto")]
        public string NomeProjeto { get; set; }

        [StringLength(1)]
        [Required]
        [DisplayName("Ativo")]
        public string Ativo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_PROJETO> INSCR_BQ_QUESTAO_PROJETO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
