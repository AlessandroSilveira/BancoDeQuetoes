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

		public int NumeroStatus { get; set; }
		public bool Ativo { get; set; }
	}
}