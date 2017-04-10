using System.Collections.Generic;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
	public partial class Area
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Area()
		{
			INSCR_BQ_TOPICO_ATRIBUIDO = new HashSet<INSCR_BQ_TOPICO_ATRIBUIDO>();
			INSCR_BQ_TOPICO = new HashSet<Disciplina>();
			INSCR_BQ_TOP_DISC_CARGO = new HashSet<INSCR_BQ_TOP_DISC_CARGO>();
		}

		
		public int AreaId { get; set; }
		
		public string Descricao { get; set; }

		public bool ConhecimentoEspecifico { get; set; }
		
		public bool Ativo { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Disciplina> INSCR_BQ_TOPICO { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }
	}
}
