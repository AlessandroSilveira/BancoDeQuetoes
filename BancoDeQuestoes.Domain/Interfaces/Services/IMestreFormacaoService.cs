using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IMestreFormacaoService : IDisposable
	{
		MestreFormacao Add(MestreFormacao obj);
		MestreFormacao GetById(Guid id);
		IEnumerable<MestreFormacao> GetAll();
		MestreFormacao Update(MestreFormacao obj);
		void Remove(Guid id);
	}
}
