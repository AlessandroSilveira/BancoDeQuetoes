using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class RevisorFormacaoViewModel
	{

		public RevisorFormacaoViewModel()
		{
			RevisorFormacaoId = new Guid();
			RevisorId = new Guid();
		}

		[Key]
		[DisplayName("Primeira Formação")]
		[Required]
		public Guid RevisorFormacaoId { get; set; }

		public Guid RevisorId { get; set; }

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