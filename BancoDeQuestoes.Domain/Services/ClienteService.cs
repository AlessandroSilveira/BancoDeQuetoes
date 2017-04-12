using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class ClienteService : ServiceBase<Cliente>, IClienteService
	{
		private IClienteRepository _clienteRepository;

		public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
		{
			_clienteRepository = clienteRepository;
		}

		public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
		{
			return clientes.Where(c => c.ClienteEspecial(c));
		}
	}
}
