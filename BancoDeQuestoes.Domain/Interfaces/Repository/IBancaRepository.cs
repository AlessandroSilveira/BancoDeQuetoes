using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
    public interface IBancaRepository :IRepository<Banca>
    {
        void Dispose();
    }
}