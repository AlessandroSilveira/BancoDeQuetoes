using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
    public class TopicoAtribuidoRepositoryBase : RepositoryBase<TopicoAtribuido>, ITopicoAtribuidoRepository
	{
	    public TopicoAtribuidoRepositoryBase(Db context) : base(context)
	    {
	    }
    }
}
