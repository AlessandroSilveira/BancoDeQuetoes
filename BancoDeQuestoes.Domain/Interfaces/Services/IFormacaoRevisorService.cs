using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IFormacaoRevisorService : IDisposable
	{
		RevisorFormacao Add(RevisorFormacao obj);
		RevisorFormacao GetById(Guid id);
		IEnumerable<RevisorFormacao> GetAll();
		RevisorFormacao Update(RevisorFormacao obj);
		void Remove(Guid id);
	}
}
