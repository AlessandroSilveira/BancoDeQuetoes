using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IFormacaoRevisoresRepository : IRepository<RevisorFormacao>
	{
	    void Dispose();
	}
}
