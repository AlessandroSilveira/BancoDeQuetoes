using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class BancaViewModel
	{
		[Key]
		public int BancaId { get; set; }

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