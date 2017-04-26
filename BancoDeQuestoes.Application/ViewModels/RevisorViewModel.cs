using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class RevisorViewModel
	{
		public RevisorViewModel()
		{
			RevisorId = new Guid();
		}

		[Key]
		public Guid RevisorId { get; set; }

		[StringLength(500)]
		[DisplayName("Nome")]
		[Required]
		public string Nome { get; set; }

		[StringLength(8)]
		[DisplayName("CEP")]
		[Required]
		public string Cep { get; set; }

		[StringLength(100)]
		[DisplayName("Endereço")]
		[Required]
		public string Endereco { get; set; }

		[StringLength(100)]
		[DisplayName("Complemento")]
		public string Complemento { get; set; }

		[StringLength(5)]
		[DisplayName("Número")]
		[Required]
		public string Numero { get; set; }

		[StringLength(100)]
		[DisplayName("Bairro")]
		[Required]
		public string Bairro { get; set; }

		[StringLength(50)]
		[DisplayName("Cidade")]
		[Required]
		public string Cidade { get; set; }

		[StringLength(2)]
		[DisplayName("UF")]
		[Required]
		public string Uf { get; set; }

		[StringLength(11)]
		[DisplayName("CPF")]
		[Required]
		public string Cpf { get; set; }

		[StringLength(150)]
		[DisplayName("Email")]
		[Required]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		[StringLength(150)]
		[Required]
		[DisplayName("Email Secundário")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string EmailSecundario { get; set; }

		[StringLength(8)]
		[Required]
		[DisplayName("Telefone")]
		public string Telefone { get; set; }

		[StringLength(9)]
		[Required]
		[DisplayName("Celular")]
		public string Celular { get; set; }

		[StringLength(10)]
		[Required]
		[DisplayName("Senha")]
		public string Senha { get; set; }

		
		[Required (ErrorMessage="Escolha a área que esse revisor pertence.")]
		[DisplayName("Área")]
		public Guid AreaId { get; set; }

		[Required]
		[DisplayName("Ativo")]
		public bool Ativo { get; set; }

		public virtual Area Area { get; set; }
	}
}
