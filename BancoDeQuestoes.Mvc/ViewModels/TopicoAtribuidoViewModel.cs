using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class TopicoAtribuidoViewModel
	{
		[Key]
		public int TopicoAtribuidoId { get; set; }

		public int ProjetoId { get; set; }
		public int AreaId { get; set; }
		public int MestreId { get; set; }
		public int DisciplinaId { get; set; }

		[Required(ErrorMessage = "O campo Código do Projeto deve ser preenchido"), StringLength(150), DisplayName("Código do Projeto")]
		public string CodigoProjeto { get; set; }

		[Required(ErrorMessage = "O campo Número da Questão deve ser preenchido"),  DisplayName("Número da Questão")]
		public int NumeroQuestao { get; set; }

		[Required(ErrorMessage = "O campo Data de Entrega deve ser preenchido"), DisplayName("Data de Entrega")]
		public DateTime DataEntrega { get; set; }

		[DisplayName("Status"), StringLength(150)]
		public string Status { get; set; }

		[Required(ErrorMessage = "O campo Nível deve ser preenchido"), DisplayName("Nível"), StringLength(150)]
		public string Nivel { get; set; }

		[Required(ErrorMessage = "O campo Valor deve ser preenchido"), DisplayName("Valor")]
		public decimal Valor { get; set; }

		[DisplayName("Questões Realizadas")]
		public int QuestoesRealizadas { get; set; }

		[DisplayName("Aceito")]
		public bool Aceito { get; set; }

		[Required(ErrorMessage = "O campo Observação deve ser preenchido"), DisplayName("Observação"), StringLength(150)]
		public string Observacao { get; set; }

		[DisplayName("Data de Atribuição")]
		public DateTime DataAtribuicao { get; set; }

		[DisplayName("Convite Aceito")]
		public bool ConviteAceito { get; set; }
	}
}