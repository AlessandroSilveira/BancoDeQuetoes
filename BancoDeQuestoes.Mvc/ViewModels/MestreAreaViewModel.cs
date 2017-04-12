using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class MestreAreaViewModel
	{
		[Key]
		public int MestreAreaId { get; set; }
		public int MestreId { get; set; }

		
		public int AreaId { get; set; }

		
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo Ativo deve ser preenchido"), DisplayName("Ativo")]
		public bool Ativo { get; set; }
	}
}