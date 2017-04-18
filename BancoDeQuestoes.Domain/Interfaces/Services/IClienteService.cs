using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IClienteService : IServiceBase<Cliente>
	{
		IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
	}
}
