using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class FormacaoRevisorViewModel
	{
		[Key]
		[DisplayName("Primeira Formação")]
		[Required]
		public int FormacaoRevisorId { get; set; }

		public int RevisorId { get; set; }

		[StringLength(150)]
		[DisplayName("Instituição")]
		[Required]
		public string Instituicao { get; set; }

		[DisplayName("Formação")]
		[Required]
		[StringLength(150)]
		public string Formacao { get; set; }

		
		[DisplayName("Ativo")]
		[Required]
		public bool Ativo { get; set; }

		
	}
}