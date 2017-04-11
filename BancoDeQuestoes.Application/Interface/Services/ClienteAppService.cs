using System.Collections.Generic;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
	{
		private readonly IClienteService _clienteService;

		public ClienteAppService(IClienteService clienteService) : base(clienteService)
		{
			_clienteService = clienteService;
		}


		public IEnumerable<Cliente> ObterClientesEspeciais()
		{
			return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
		}

	
	}
}
