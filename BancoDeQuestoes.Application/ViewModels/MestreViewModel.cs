using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class MestreViewModel
	{
		public MestreViewModel()
		{
			MestreId = new Guid();
		}

		[Key]
		public Guid MestreId { get; set; }

		[Required(ErrorMessage = "O campo CPF deve ser preenchido"), StringLength(11),DisplayName("CPF")]
		public string Cpf { get; set; }

		[Required(ErrorMessage = "O campo Nome deve ser preenchido"), StringLength(150), DisplayName("Nome")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo CEP deve ser preenchido"), StringLength(10), DisplayName("CEP")]
		public string Cep { get; set; }

		[Required(ErrorMessage = "O campo Endereço deve ser preenchido"), StringLength(150), DisplayName("Endereço")]
		public string Endereco { get; set; }

		[StringLength(150), DisplayName("Complemento")]
		public string Complemento { get; set; }

		[Required(ErrorMessage = "O campo Número deve ser preenchido"), StringLength(5), DisplayName("Número")]
		public string Numero { get; set; }

		[Required(ErrorMessage = "O campo Bairro deve ser preenchido"), StringLength(150), DisplayName("Bairro")]
		public string Bairro { get; set; }

		[Required(ErrorMessage = "O campo Cidade deve ser preenchido"), StringLength(150), DisplayName("Cidade")]
		public string Cidade { get; set; }

		[Required(ErrorMessage = "O campo Estado deve ser preenchido"), StringLength(2), DisplayName("Estado")]
		public string Estado { get; set; }

		[Required(ErrorMessage = "O campo E-mail deve ser preenchido"), StringLength(150), DisplayName("E-mail")]
		public string Email { get; set; }

		[Required(ErrorMessage = "O campo Segundo E-mail deve ser preenchido"), StringLength(150), DisplayName("Segundo E-mail")]
		public string EmailSecundario { get; set; }

		[Required(ErrorMessage = "O campo Telefone deve ser preenchido"), StringLength(15), DisplayName("Telefone")]
		public string Telefone { get; set; }

		[Required(ErrorMessage = "O campo Celular deve ser preenchido"), StringLength(15), DisplayName("Celular")]
		public string Celular { get; set; }

		[Required(ErrorMessage = "O campo Banca deve ser preenchido"), StringLength(150), DisplayName("Banca")]
		public Guid  BancaId { get; set; }

		[Required(ErrorMessage = "O campo Filhos deve ser preenchido"), StringLength(2), DisplayName("Filhos")]
		public string Filhos { get; set; }

		[Required(ErrorMessage = "O campo PIS deve ser preenchido"), StringLength(20), DisplayName("PIS")]
		public string Pis { get; set; }

		[Required(ErrorMessage = "O campo Minicurriculo deve ser preenchido"), StringLength(150), DisplayName("Mini-Curriculo")]
		public string Minicurriculo { get; set; }

		[Required(ErrorMessage = "O campo Banco deve ser preenchido"), StringLength(150), DisplayName("Banco")]
		public string Banco { get; set; }

		[Required(ErrorMessage = "O campo Agência deve ser preenchido"), StringLength(150), DisplayName("Agência")]
		public string Agencia { get; set; }

		[Required(ErrorMessage = "O campo Tipo de Conta deve ser preenchido"), StringLength(11), DisplayName("Tipo de Conta")]
		public string TipoConta { get; set; }

		[Required(ErrorMessage = "O campo Conta deve ser preenchido"), StringLength(11), DisplayName("Conta")]
		public string Conta { get; set; }
		
		public bool Ativo { get; set; }
		public virtual Banca Banca { get; set; }
	}
}