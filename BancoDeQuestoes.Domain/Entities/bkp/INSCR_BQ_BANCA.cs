using System.Collections.Generic;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
	public class INSCR_BQ_BANCA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_BANCA()
        {
            INSCR_BQ_MESTRE = new HashSet<INSCR_BQ_MESTRE>();
        }
       
        public int ID_BANCA { get; set; }
        public string DESC_BANCA { get; set; }
        public string DESC_STATUS { get; set; }
        public string DESC_VALOR_PORCENTAGEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_MESTRE> INSCR_BQ_MESTRE { get; set; }
    }
}
