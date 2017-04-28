using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IMestreAreaService : IDisposable
	{
		MestreArea Add(MestreArea obj);
		MestreArea GetById(Guid id);
		IEnumerable<MestreArea> GetAll();
		MestreArea Update(MestreArea obj);
		void Remove(Guid id);
	}
}
