using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface
{
	public interface IProdutoAppService : IAppServiceBase<Produto>
	{
		IEnumerable<Produto> BuscarPorNome(string nome);
	}
}
