using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IQuestaoAppService : IAppServiceBase<Questao>
	{
		IEnumerable<Questao> GetListaGerenciamento();
	}
}