using System.Collections.Generic;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
	public  class INSCR_ADMIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_ADMIN()
        {
            INSCR_ADMIN_PERFIL = new HashSet<INSCR_ADMIN_PERFIL>();
            
        }

        public int ID_ADMIN { get; set; }
        public string DESC_NOME { get; set; }
        public string DESC_PERFIL { get; set; }
        public string DESC_SENHA { get; set; }
        public string DESC_USUARIO { get; set; }
        public string DESC_ATIVO { get; set; }
        public string DESC_EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_ADMIN_PERFIL> INSCR_ADMIN_PERFIL { get; set; }

      
    }
}
