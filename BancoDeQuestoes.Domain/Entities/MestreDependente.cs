using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Models
{
	public class MestreDependente
	{
		[Key]
		[Required]
		public int IdMestreDependente { get; set; }

		[Required]
		public int IDMestre { get; set; }

		[StringLength(100)]
		[Required]
		[DisplayName("Nome")]
		public string Nome { get; set; }

		[StringLength(100)]
		[Required]
		[DisplayName("Documento")]
		public string Documento { get; set; }

		
		[Required]
		[DisplayName("Data de Nascimento")]
		public DateTime DataDeNascimento { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual INSCR_BQ_MESTRE INSCR_BQ_MESTRE { get; set; }

	}
}