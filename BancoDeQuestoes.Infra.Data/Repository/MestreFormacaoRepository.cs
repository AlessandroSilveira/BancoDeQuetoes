using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class MestreFormacaoRepositoryBase : RepositoryBase<MestreFormacao>, IMestreFormacaoRepository
	{
	    public MestreFormacaoRepositoryBase(Db context) : base(context)
	    {
	    }
	}
}
