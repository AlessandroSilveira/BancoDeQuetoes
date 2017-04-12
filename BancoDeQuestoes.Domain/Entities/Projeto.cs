using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
    public  class Projeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projeto()
        {
            //INSCR_BQ_QUESTAO_PROJETO = new HashSet<INSCR_BQ_QUESTAO_PROJETO>();
            //INSCR_BQ_TOP_DISC_CARGO = new HashSet<INSCR_BQ_TOP_DISC_CARGO>();
            //INSCR_BQ_TOPICO_ATRIBUIDO = new HashSet<INSCR_BQ_TOPICO_ATRIBUIDO>();
        }

       
        public int ProjetoId { get; set; }
       
        public int CodigoProjeto { get; set; }
      
        public string NomeProjeto { get; set; }
       
        public string Ativo { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_QUESTAO_PROJETO> INSCR_BQ_QUESTAO_PROJETO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
