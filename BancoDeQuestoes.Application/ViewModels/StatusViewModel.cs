using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class StatusViewModel
	{
		public StatusViewModel()
		{
			StatusId = Guid.NewGuid();
		}

		[Key]
		public Guid StatusId { get; set; }

		[Required(ErrorMessage = "O campo Nome deve ser preenchido"), StringLength(150), DisplayName("Nome")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo Ativo deve ser preenchido"), StringLength(150), DisplayName("Ativo")]
		public bool Ativo { get; set; }
	}
}