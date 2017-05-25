using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class MestreRepositoryBase : RepositoryBase<Mestre>, IMestreRepository
	{
	    public MestreRepositoryBase(Db context) : base(context)
	    {
	    }
	}
}
