using System.Data.Entity;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
    public class ConviteMestreRepository : RepositoryBase<ConviteMestre>, IConviteMestreRepository
    {
        public ConviteMestreRepository(Db context) : base(context)
        {
        }

    }
}