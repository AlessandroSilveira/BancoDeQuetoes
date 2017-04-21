using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class BancaViewModel
	{

		public BancaViewModel()
		{
			BancaId = new Guid();
		}

		[Key]
		public Guid BancaId { get; set; }

		[Required(ErrorMessage = "Preencha o campo Nome da Banca")]
		[DisplayName("Nome da Banca")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Preencha o campo Porcentagem da Banca")]
		[DisplayName("Porcentagem da Banca")]
		public decimal Valor { get; set; }

		[Required(ErrorMessage = "Preencha o campo Ativo")]
		[DisplayName("Ativo")]
		public bool Ativo { get; set; }
	}
}