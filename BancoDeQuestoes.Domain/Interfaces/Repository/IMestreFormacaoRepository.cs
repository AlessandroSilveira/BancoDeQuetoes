using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IMestreFormacaoRepository : IRepository<MestreFormacao>
	{
	    void Dispose();
	}
}
