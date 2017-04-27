using System.Collections.Generic;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Repository;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaDisciplina;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico;

namespace BancoDeQuestoes.Infra.Data
{
	public class ItensPesquisaTopico
	{
		private static readonly IDictionary<string, IItemPesquisaTopico> Itens =
			new Dictionary<string, IItemPesquisaTopico>()
			{
				{"Projeto_ProjetoId", new ProjetoId()},
				{"MestreId", new MestreId()},
				{"AreaId", new AreaId()},
				{"DisciplinaId", new DisciplinaId()},
				{"Nivel", new Nivel()}
			};

		public IItemPesquisaTopico Pega(string nome)
		{
			return Itens[nome];
		}
	}
}