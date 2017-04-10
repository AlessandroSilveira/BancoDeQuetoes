using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class DisciplinaViewModel
	{
		[Key]
		[DisplayName("Id Discipliina")]
		public int DisciplinaId { get; set; }

		[DisplayName("Área")]
		public int AreaId { get; set; }

		[StringLength(150)]
		[DisplayName("Titulo da Disciplina")]
		public string Nome { get; set; }

		[StringLength(150)]
		[DisplayName("Descrição da Disciplina")]
		public string Descricao { get; set; }

		[StringLength(150)]
		[DisplayName("Bibliografia")]
		public string Bibliografia { get; set; }

		
		[DisplayName("Ativo")]
		public bool Ativo { get; set; }

		[Required]
		[StringLength(150)]
		[DisplayName("Nível")]
		public string Nivel { get; set; }

		public virtual Area Area { get; set; }

		//[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		//public virtual ICollection<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }

		//[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		//public virtual ICollection<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
	}
}