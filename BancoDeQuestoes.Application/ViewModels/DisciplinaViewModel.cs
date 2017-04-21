using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.ViewModels
{
	public class DisciplinaViewModel
	{

		public DisciplinaViewModel()
		{
			DisciplinaId = new Guid();
			AreaId = new Guid();
		}

		[Key]
		[DisplayName("Id Discipliina")]
		public Guid DisciplinaId { get; set; }

		[Required(ErrorMessage = "Escolha uma Área que essa Disciplina pertence.")]
		[DisplayName("Área")]
		public Guid AreaId { get; set; }

		[StringLength(150)]
		[Required(ErrorMessage = "Informe um Título da Disciplina.")]
		[DisplayName("Titulo da Disciplina")]
		public string Nome { get; set; }

		[StringLength(150)]
		[Required(ErrorMessage = "Informe uma Descrição da Disciplina.")]
		[DisplayName("Descrição da Disciplina")]
		public string Descricao { get; set; }

		[StringLength(150)]
		[DisplayName("Bibliografia")]
		[Required(ErrorMessage = "Informe uma Bibliografia.")]
		public string Bibliografia { get; set; }

		
		[DisplayName("Ativo")]
		[Required(ErrorMessage = "Escolha se está ativo.")]
		public bool Ativo { get; set; }

		[Required(ErrorMessage = "Escolha se está Nível.")]
		[StringLength(150)]
		[DisplayName("Nível")]
		public string Nivel { get; set; }

		public virtual Area Area { get; set; }

	}
}