using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IStatusRepository : IRepository<Status>
	{
	    void Dispose();
	   Status ObterDescricaoStatus(Expression<Func<Status, bool>> func);
        
    }
}