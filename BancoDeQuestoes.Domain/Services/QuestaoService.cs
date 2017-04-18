using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class QuestaoService : ServiceBase<Questao>, IQuestaoService
	{
		public QuestaoService(IRepositoryBase<Questao> repositoryBase) : base(repositoryBase)
		{
		}

		
	}
}