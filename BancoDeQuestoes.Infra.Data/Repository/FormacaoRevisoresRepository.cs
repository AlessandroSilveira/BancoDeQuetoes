using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class FormacaoRevisoresRepositoryBase : RepositoryBase<RevisorFormacao> , IFormacaoRevisoresRepository
	{
	    public FormacaoRevisoresRepositoryBase(Db context) : base(context)
	    {
	    }
	}
}
