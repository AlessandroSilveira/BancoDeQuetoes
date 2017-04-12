using System.Collections.Generic;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application
{
	public class ProdutoAppService : AppServiceBase<Produto>,IProdutoAppService
	{
		private readonly IProdutoService _produtoService;

		public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
		{
			_produtoService = produtoService;
		}


		public IEnumerable<Produto> BuscarPorNome(string nome)
		{
			return _produtoService.BuscarPorNome(nome);
		}
	}
}
