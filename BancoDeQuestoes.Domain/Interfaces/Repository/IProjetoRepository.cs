using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IProjetoRepository : IRepository<Projeto>
	{
	    void Dispose();
	}
}
