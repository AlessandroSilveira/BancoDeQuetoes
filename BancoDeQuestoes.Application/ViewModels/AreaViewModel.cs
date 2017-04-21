using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class AreaViewModel
	{

		public AreaViewModel()
		{
			AreaId = Guid.NewGuid();
		}

		[Key]
		public Guid AreaId { get; set; }

		[Required(ErrorMessage = "Preencha o campo Área")]
		[DisplayName("Descrição")]
		public string Descricao { get; set; }

		[Required(ErrorMessage = "Preencha o campo É Conhecimento Específico?")]
		[DisplayName("É Conhecimento Específico?")]
		public bool ConhecimentoEspecifico { get; set; }

		[Required(ErrorMessage = "Preencha o campo Ativo")]
		[DisplayName("Ativo")]
		public bool Ativo { get; set; }
	}
}