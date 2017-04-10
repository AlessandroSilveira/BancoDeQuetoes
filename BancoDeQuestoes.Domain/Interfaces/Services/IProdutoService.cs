using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IProdutoService : IServiceBase<Produto>
	{
		IEnumerable<Produto> BuscarPorNome(string nome);
	}
}
