using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IMestreDependenteRepository : IRepository<MestreDependente>
	{
	    void Dispose();
	}
}
