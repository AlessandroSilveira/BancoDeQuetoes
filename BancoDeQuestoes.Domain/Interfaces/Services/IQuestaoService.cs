using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IQuestaoService : IServiceBase<Questao>
	{
		IEnumerable<Questao> GetListaGerenciamentoQuestao();
	}
}