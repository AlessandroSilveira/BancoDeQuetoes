using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IBancaService :  IDisposable
	{
		Banca Add(Banca obj);

		Banca GetById(Guid id);

		IEnumerable<Banca> GetAll();

		Banca Update(Banca obj);

		void Remove(Guid id);

	}
}
