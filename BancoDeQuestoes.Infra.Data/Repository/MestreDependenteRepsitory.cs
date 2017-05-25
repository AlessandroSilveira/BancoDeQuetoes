using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class MestreDependenteRepsitory : RepositoryBase<MestreDependente>, IMestreDependenteRepository
	{
	    public MestreDependenteRepsitory(Db context) : base(context)
	    {
	    }
	}
}
