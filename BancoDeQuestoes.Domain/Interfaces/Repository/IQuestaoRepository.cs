using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IQuestaoRepository : IRepository<Questao>
	{
	    void Dispose();
	}
}
