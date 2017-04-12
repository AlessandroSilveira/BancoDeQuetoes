using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IClienteAppService : IAppServiceBase<Cliente>
	{
		IEnumerable<Cliente> ObterClientesEspeciais();
	}
}
