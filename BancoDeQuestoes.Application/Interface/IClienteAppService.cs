using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface
{
	public interface IClienteAppService : IAppServiceBase<Cliente>
	{
		IEnumerable<Cliente> ObterClientesEspeciais();
	}
}
