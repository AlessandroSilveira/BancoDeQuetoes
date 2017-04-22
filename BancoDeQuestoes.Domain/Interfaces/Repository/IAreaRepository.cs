using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
    public interface IAreaRepository : IRepository<Area>
    {
        void Dispose();
    }
}