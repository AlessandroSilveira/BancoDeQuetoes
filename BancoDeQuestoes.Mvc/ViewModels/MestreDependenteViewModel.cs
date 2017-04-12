using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class MestreDependenteViewModel
	{
		[Key]
		public int MestreDependenteId { get; set; }

		public int MestreId { get; set; }

		[Required(ErrorMessage = "O campo Nome deve ser preenchido"), StringLength(150), DisplayName("Nome")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo Documento deve ser preenchido"), StringLength(150), DisplayName("Documento")]
		public string Documento { get; set; }

		[Required(ErrorMessage = "O campo Data de Nascimento deve ser preenchido"),  DisplayName("Data de Nascimento")]
		public DateTime DataNascimento { get; set; }

		[Required(ErrorMessage = "O campo Ativo deve ser preenchido"), DisplayName("Ativo")]
		public bool Ativo { get; set; }
	}
}