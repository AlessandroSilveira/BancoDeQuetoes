using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class MestreFormacaoService : ServiceBase<MestreFormacao>,IMestreFormacaoService
	{
		public MestreFormacaoService(IRepositoryBase<MestreFormacao> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
