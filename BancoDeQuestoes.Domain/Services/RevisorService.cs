using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public  class RevisorService : ServiceBase<Revisor>, IRevisorService
	{
		private IRevisorRepository _revisorRepository;
		public RevisorService(IRepositoryBase<Revisor> repositoryBase, IRevisorRepository revisorRepository) : base(repositoryBase)
		{
			_revisorRepository = revisorRepository;
		}
	}
}
