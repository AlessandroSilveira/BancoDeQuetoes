using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IAreaService :IDisposable
	{
		Area Add(Area obj);

		Area GetById(Guid id);

		IEnumerable<Area> GetAll();

		Area Update(Area obj);

		void Remove(Guid id);

	
	}
}
