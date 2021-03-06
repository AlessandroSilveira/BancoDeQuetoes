using System.Collections.Generic;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
	public class INSCR_BQ_QUESTAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BQ_QUESTAO()
        {
            INSCR_BQ_CONVITE_REVISAO_MESTRE = new HashSet<INSCR_BQ_CONVITE_REVISAO_MESTRE>();
            INSCR_BQ_CONVITE_REVISOR = new HashSet<INSCR_BQ_CONVITE_REVISOR>();
            INSCR_BQ_QUESTAO_RECICLAR_REVISOR = new HashSet<INSCR_BQ_QUESTAO_RECICLAR_REVISOR>();
            INSCR_BQ_QUESTAO_REVISADA = new HashSet<INSCR_BQ_QUESTAO_REVISADA>();
            INSCR_BQ_QUESTAO_REVISOR = new HashSet<INSCR_BQ_QUESTAO_REVISOR>();
            INSCR_BQ_RESPOSTA = new HashSet<INSCR_BQ_RESPOSTA>();
            INSCR_BQ_RESPOSTA_REVISADA = new HashSet<INSCR_BQ_RESPOSTA_REVISADA>();
        }
		
        public int ID_QUESTAO { get; set; }
        public int ID_TOPICO_ATRIBUIDO { get; set; }
        public int NUM_QUESTAO { get; set; }
        public string DESC_QUESTAO { get; set; }
        public string DESC_ARQUIVO { get; set; }
        public string DESC_STATUS { get; set; }
        public int? NUM_REVISAO { get; set; }
        public int? DESC_FINALIZAR { get; set; }
        public string DESC_NIVEL { get; set; }
        public string DESC_IMAGEM { get; set; }
        public string DESC_CONVITE_ACEITE { get; set; }
        public string DESC_REVISAO_1 { get; set; }
        public string DESC_REVISAO_2 { get; set; }
        public string EXPORTAR_SEBRAE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_CONVITE_REVISAO_MESTRE> INSCR_BQ_CONVITE_REVISAO_MESTRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_CONVITE_REVISOR> INSCR_BQ_CONVITE_REVISOR { get; set; }

        public virtual INSCR_BQ_TOPICO_ATRIBUIDO INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_RECICLAR_REVISOR> INSCR_BQ_QUESTAO_RECICLAR_REVISOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_REVISADA> INSCR_BQ_QUESTAO_REVISADA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_QUESTAO_REVISOR> INSCR_BQ_QUESTAO_REVISOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_RESPOSTA> INSCR_BQ_RESPOSTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
    }
}
