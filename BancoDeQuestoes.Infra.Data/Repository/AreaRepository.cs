using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class AreaRepositoryBase : RepositoryBase<Area>, IAreaRepository
	{
	    public AreaRepositoryBase(Db context) : base(context)
	    {
	    }
	}
}