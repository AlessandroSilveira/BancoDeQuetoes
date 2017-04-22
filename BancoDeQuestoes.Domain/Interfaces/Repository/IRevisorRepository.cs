using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
    public interface IRevisorRepository : IRepository<Revisor>
    {
        void Dispose();
    }
}