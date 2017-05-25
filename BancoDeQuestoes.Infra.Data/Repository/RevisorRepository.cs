using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class RevisorRepositoryBase : RepositoryBase<Revisor>, IRevisorRepository
    {
        public RevisorRepositoryBase(Db context) : base(context)
        {
        }
    }
}