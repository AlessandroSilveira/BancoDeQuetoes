using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class QuestaoViewModel
	{
		[Key]
		public int QuestaoId { get; set; }

		public int TopicoAtribuidoId { get; set; }

		[Required(ErrorMessage = "O campo Número da Questão deve ser preenchido"), DisplayName("Número da Questão")]
		public int NumeroQuestao { get; set; }

		[Required(ErrorMessage = "O campo Descricão da Questão deve ser preenchido"), StringLength(150), DisplayName("Descrição da Questão")]
		public string Descricao { get; set; }

		[ StringLength(150), DisplayName("Arquivo")]
		public string Arquivo { get; set; }

		[StringLength(150), DisplayName("Status")]
		public string Status { get; set; }

		[DisplayName("Número de Revisões")]
		public int NumeroDeRevisoes { get; set; }

		[DisplayName("Finalizar Questao")]
		public int Finalizar { get; set; }

		[DisplayName("Nível da Questao")]
		public string Nivel { get; set; }

		[DisplayName("Imagem da Questao")]
		public string Imagem { get; set; }

		[DisplayName("Convite Aceito")]
		public bool ConviteAceito { get; set; }
	}
}