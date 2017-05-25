using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class QuestaoRepositoryBase : RepositoryBase<Questao>, IQuestaoRepository
	{
	    public QuestaoRepositoryBase(Db context) : base(context)
	    {
	    }
	}
}