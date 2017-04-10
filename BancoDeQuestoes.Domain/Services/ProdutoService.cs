using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class ProdutoService : ServiceBase<Produto> , IProdutoService
	{
		private readonly IProdutoRepository _produtoRepository;

		public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
		{
			_produtoRepository = produtoRepository;
		}

		public IEnumerable<Produto> BuscarPorNome(string nome)
		{
			return _produtoRepository.BuscarPorNome(nome);
		}
	}
}
