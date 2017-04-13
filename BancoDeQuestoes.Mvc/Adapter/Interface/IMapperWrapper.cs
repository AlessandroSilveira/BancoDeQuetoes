using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.Adapter.Interface
{
	public interface IMapperWrapper
	{
		object Map(Type type, Type type1, IEnumerable<Projeto> getAll);
	}
}