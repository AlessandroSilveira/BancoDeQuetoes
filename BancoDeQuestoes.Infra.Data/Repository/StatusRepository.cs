using System;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class StatusRepositoryBase : RepositoryBase<Status>, IStatusRepository
	{
	    public StatusRepositoryBase(Db context) : base(context)
	    {
	    }
	}
}
