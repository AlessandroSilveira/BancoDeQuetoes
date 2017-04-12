using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.ViewModels
{
	public class FormacaoRevisorViewModel
	{
		[Key]
		[DisplayName("Primeira Formação")]
		[Required]
        [ForeignKey("FormacaoRevisor")]
		public int FormacaoRevisorId { get; set; }
        public virtual FormacaoRevisor FormacaoRevisor { get; set; }

        [ForeignKey("Revisor")]
		public int RevisorId { get; set; }
        public virtual Revisor Revisor { get; set; }

		[StringLength(150)]
		[DisplayName("Instituição")]
		[Required]
		public string Instituicao { get; set; }

		[DisplayName("Formação")]
		[Required]
		[StringLength(150)]
		public string Formacao { get; set; }

		
		[DisplayName("Ativo")]
		[Required]
		public bool Ativo { get; set; }

		
	}
}