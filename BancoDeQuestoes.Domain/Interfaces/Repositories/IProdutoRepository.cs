using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Domain.Interfaces
{
	public interface IProdutoRepository : IRepositoryBase<Produto>
	{
		IEnumerable<Produto> BuscarPorNome(string nome);
	}
}
