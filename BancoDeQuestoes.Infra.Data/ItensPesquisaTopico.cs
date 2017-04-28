using System.Collections.Generic;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico;

namespace BancoDeQuestoes.Infra.Data
{
	public class ItensPesquisaTopico
	{
		private static readonly IDictionary<string, IItemPesquisaTopico> Itens =
			new Dictionary<string, IItemPesquisaTopico>()
			{
				{"Nome", new Nome()},
				{"AreaId", new AreaId()},
				{"DisciplinaId", new DisciplinaId()},
				{"Descricao", new Descricao()},
				{"Nivel", new Nivel()}
			};

		public IItemPesquisaTopico Pega(string nome)
		{
			return Itens[nome];
		}
	}
}