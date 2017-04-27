using System.Collections.Generic;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaDisciplina;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class ItensPesquisaDusciplina
	{
		private static readonly IDictionary<string, IItensPesquisaDisciplina> Itens =
			new Dictionary<string, IItensPesquisaDisciplina>()
			{
				{"Nome", new DescTitulo()},
				{"DisciplinaId", new IdDisciplina()},
				{"Bibliografia", new DescBibliografia()},
				{"Nivel", new DescNivel()},
				{"Descricao", new DescTopico()}
			};

		public IItensPesquisaDisciplina Pega(string nome)
		{
			return Itens[nome];
		}
	}
}