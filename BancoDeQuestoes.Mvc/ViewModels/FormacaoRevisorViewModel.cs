using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class FormacaoRevisorViewModel
	{
		[DisplayName("Primeira Formação")]
		[Required]
		public string DESC_FORMACAO { get; set; }

		[StringLength(50)]
		[DisplayName("Instituição")]
		[Required]
		public string DESC_INSTITUICAO { get; set; }

		[DisplayName("Segunda Formação")]
		public string DESC_FORMACAO_2 { get; set; }

		[StringLength(50)]
		[DisplayName("Segunda Instituição")]
		public string DESC_INSTITUICAO_2 { get; set; }

		[DisplayName("Terceira Formação")]
		public string DESC_FORMACAO_3 { get; set; }

		[StringLength(50)]
		[DisplayName("Terceira Instituição")]
		public string DESC_INSTITUICAO_3 { get; set; }
	}
}