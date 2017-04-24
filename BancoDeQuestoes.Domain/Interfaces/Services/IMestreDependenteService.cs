using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public  interface IMestreDependenteService : IDisposable
	{

		MestreDependente Add(MestreDependente obj);

		MestreDependente GetById(Guid id);

		IEnumerable<MestreDependente> GetAll();

		MestreDependente Update(MestreDependente obj);

		void Remove(Guid id);

		
	}
}
