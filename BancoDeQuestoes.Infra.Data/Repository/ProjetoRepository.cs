using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class ProjetoRepositoryBase : RepositoryBase<Projeto>, IProjetoRepository
    {
        public ProjetoRepositoryBase(Db context) : base(context)
        {
        }
    }
}