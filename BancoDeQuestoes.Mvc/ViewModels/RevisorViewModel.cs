﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class RevisorViewModel
	{
		[Key]
		public int RevisorId { get; set; }

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

		
		[Required]
		[DisplayName("Área")]
		public int AreaId { get; set; }

		[Required]
		[DisplayName("Ativo")]
		public bool Ativo { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<INSCR_BQ_CONVITE_REVISOR> INSCR_BQ_CONVITE_REVISOR { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<INSCR_BQ_QUESTAO_RECICLAR_REVISOR> INSCR_BQ_QUESTAO_RECICLAR_REVISOR { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<INSCR_BQ_QUESTAO_REVISADA> INSCR_BQ_QUESTAO_REVISADA { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<INSCR_BQ_QUESTAO_REVISOR> INSCR_BQ_QUESTAO_REVISOR { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
	}
}
