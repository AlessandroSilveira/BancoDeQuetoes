using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class AreaViewModel
	{
		[Key]
		public int AreaId { get; set; }

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