using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

	    public Status ObterDescricaoStatus(Expression<Func<Status, bool>> func)
	    {
	        return Search(func).FirstOrDefault();
	    }
	}
}
