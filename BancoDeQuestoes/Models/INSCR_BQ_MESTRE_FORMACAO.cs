using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Models
{
	public class INSCR_BQ_MESTRE_FORMACAO
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public INSCR_BQ_MESTRE_FORMACAO()
		{
			var INSCR_BQ_MESTRE = new HashSet<INSCR_BQ_MESTRE>();
		}

		[Key]
		[Required]
		public int ID_MESTRE_FORMACAO { get; set; }

		[StringLength(3)]
		[Required]
		[DisplayName("Id Mestre")]
		public int ID_MESTRE { get; set; }

		[StringLength(100)]
		[Required]
		[DisplayName("Tipo de Formação")]
		public string DESC_TIPO_FORMACAO { get; set; }

		[StringLength(100)]
		[Required]
		[DisplayName("Curso")]
		public string DESC_CURSO { get; set; }

		[StringLength(100)]
		[Required]
		[DisplayName("Instituição")]
		public string DESC_INSTITUICAO { get; set; }

		[StringLength(1)]
		[Required]
		[DisplayName("Entregou Cópia do Diploma?")]
		public bool DESC_COPIA_DIPLOMA { get; set; }

		[StringLength(1)]
		[Required]
		[DisplayName("Diploma está Autenticado?")]
		public bool DESC_DIPLOMA_AUTENTICADO { get; set; }

		[StringLength(3)]
		[Required]
		[DisplayName("Número de Cópias Autenticadas:")]
		public int DESC_NUMERO_COPIAS { get; set; }

		public virtual INSCR_BQ_MESTRE INSCR_BQ_MESTRE { get; set; }
	}
}