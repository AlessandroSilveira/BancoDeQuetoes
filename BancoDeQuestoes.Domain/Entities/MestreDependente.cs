using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Domain.Entities
{
	public class MestreDependente
	{
		[Key]
		public int MestreDependenteId { get; set; }

		public int MestreId { get; set; }

		[Required(ErrorMessage = "O campo Nome deve ser Informado"), StringLength(150), DisplayName("Nome")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo Documento deve ser Informado"), StringLength(150), DisplayName("Documento")]
		public string Documento { get; set; }

		[Required(ErrorMessage = "O campo Data de Nascimento deve ser Informado"),  DisplayName("Data de Nascimento")]
		public DateTime DataNascimento { get; set; }

		[Required(ErrorMessage = "O campo Ativo deve ser Informado"),  DisplayName("Data de Nascimento")]
		public bool Ativo { get; set; }

		public virtual Mestre Mestre { get; set; }
	}
}
