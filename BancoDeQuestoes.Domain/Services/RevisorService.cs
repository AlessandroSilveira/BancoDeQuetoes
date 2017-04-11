using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public  class RevisorService : ServiceBase<Revisor>, IRevisorService
	{
		public RevisorService(IRepositoryBase<Revisor> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
