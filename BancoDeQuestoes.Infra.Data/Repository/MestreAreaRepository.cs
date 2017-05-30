using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class MestreAreaRepositoryBase : RepositoryBase<MestreArea>, IMestreAreaRepository
	{
	    public MestreAreaRepositoryBase(Db context) : base(context)
	    {
	    }
	}
}
