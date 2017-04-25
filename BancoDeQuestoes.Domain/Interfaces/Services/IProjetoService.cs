using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IProjetoService : IDisposable
	{
		Projeto Add(Projeto obj);

		Projeto GetById(Guid id);

		IEnumerable<Projeto> GetAll();

		Projeto Update(Projeto obj);

		void Remove(Guid id);

		
	}
}
