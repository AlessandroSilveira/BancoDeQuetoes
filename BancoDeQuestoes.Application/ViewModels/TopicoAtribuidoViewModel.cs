using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class TopicoAtribuidoViewModel
	{
		public TopicoAtribuidoViewModel()
		{
			TopicoAtribuidoId = new Guid();
		}

		[Key]
		public Guid TopicoAtribuidoId { get; set; }
        public Guid MestreId { get; set; }

        [Required(ErrorMessage = "Escolha um Projeto"), StringLength(150), DisplayName("Projeto")]
		public Projeto Projeto { get; set; }

		[Required(ErrorMessage = "Escolha uma Área"), StringLength(150), DisplayName("Área")]
		public Area Area { get; set; }

		[Required(ErrorMessage = "Escolha um Mestre"), StringLength(150), DisplayName("Mestre")]
		public Mestre Mestre { get; set; }

		[Required(ErrorMessage = "Escolha uma Disciplina"), StringLength(150), DisplayName("Disciplina")]
		public Disciplina Disciplina { get; set; }

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

	    public Guid ProjetoId { get; set; }

	    public Guid AreaId { get; set; }

        public Guid DisciplinaId { get; set; }
    }
}