using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class MestreAreaViewModel
	{
		public MestreAreaViewModel()
		{
			MestreAreaId = new Guid();
			MestreId = new Guid();
			AreaId = new Guid();
		}

		[Key]
		public Guid MestreAreaId { get; set; }
		public Guid MestreId { get; set; }
		public Guid AreaId { get; set; }

		[Required(ErrorMessage = "O campo Nome deve ser preenchido"), DisplayName("Nome")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo Ativo deve ser preenchido"), DisplayName("Ativo")]
		public bool Ativo { get; set; }
	}
}