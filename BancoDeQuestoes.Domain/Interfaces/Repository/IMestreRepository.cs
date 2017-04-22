using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IMestreRepository : IRepository<Mestre>
	{
	    void Dispose();
	}
}
