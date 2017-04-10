using System.Collections.Generic;
using BancoDeQuestoes.Domain.Services.PesquisaDisciplina;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Services.PesquisaDisciplina;

namespace BancoDeQuestoes.Services
{
	public class ItensPesquisaDusciplina
	{
		private static readonly IDictionary<string, IItensPesquisaDisciplina> Itens =
			new Dictionary<string, IItensPesquisaDisciplina>()
			{
				{"DESC_TITULO", new DescTitulo()},
				{"ID_DISCIPLINA", new IdDisciplina()},
				{"DESC_BIBLIOGRAFIA", new DescBibliografia()},
				{"DESC_NIVEL", new DescNivel()},
				{"DESC_TOPICO", new DescTopico()}
			};

		public IItensPesquisaDisciplina Pega(string nome)
		{
			return Itens[nome];
		}
	}
}