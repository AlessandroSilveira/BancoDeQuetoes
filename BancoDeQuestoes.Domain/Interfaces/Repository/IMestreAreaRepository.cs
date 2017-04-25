using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IMestreAreaRepository : IRepository<MestreArea>
	{
		void Dispose();
	}
}
