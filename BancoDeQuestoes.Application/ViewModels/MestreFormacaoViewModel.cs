using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class MestreFormacaoViewModel
	{
		public MestreFormacaoViewModel()
		{
			MestreFormacaoId = new Guid();
			MestreId = new Guid();
		}

		[Key]
		public Guid MestreFormacaoId { get; set; }

		public Guid MestreId { get; set; }

		[Required(ErrorMessage = "O campo Tipo de Formação deve ser Informado"), StringLength(150), DisplayName("Tipo de Formação")]
		public string TipoFormacao { get; set; }

		[Required(ErrorMessage = "O campo Curso deve ser Informado"), StringLength(150), DisplayName("Curso")]
		public string Curso { get; set; }

		[Required(ErrorMessage = "O campo Instituição deve ser Informado"), StringLength(150), DisplayName("Instituição")]
		public string Instituicao { get; set; }

		[Required(ErrorMessage = "O campo Enviou cópia do diploma deve ser Informado"), DisplayName("Enviou cópia do diploma")]
		public bool CopiaDiploma { get; set; }

		[Required(ErrorMessage = "O campo Diploma está autenticado deve ser Informado"), DisplayName("Diploma está autenticado")]
		public bool DiplomaAutenticado { get; set; }

		[Required(ErrorMessage = "O campo Número de cópias autenticadas deve ser Informado"), DisplayName("Número de cópias autenticadas")]
		public int NumeroCopiaAutenticada { get; set; }

		[Required(ErrorMessage = "O campo Ativo deve ser Informado"), DisplayName("Ativo")]
		public bool Ativo { get; set; }
		
	}
}