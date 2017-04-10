using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Disciplina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disciplina()
        {
           // INSCR_BQ_TOPICO_ATRIBUIDO = new HashSet<INSCR_BQ_TOPICO_ATRIBUIDO>();
        }
		
        public int DisciplinaId { get; set; }
		public int AreaId { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Bibliografia { get; set; }
        public bool Ativo { get; set; }
        public string Nivel { get; set; }

        public virtual Area Area { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
    }
}
