using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class BancaRepositoryBase : RepositoryBase<Banca> , IBancaRepository
    {
        public BancaRepositoryBase(Db context) : base(context)
        {
        }
    }
}