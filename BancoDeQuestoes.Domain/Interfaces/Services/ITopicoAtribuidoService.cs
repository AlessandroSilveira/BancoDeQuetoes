using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface ITopicoAtribuidoService : IDisposable
	{
		TopicoAtribuido Add(TopicoAtribuido obj);
		TopicoAtribuido GetById(Guid id);
		IEnumerable<TopicoAtribuido> GetAll();
		TopicoAtribuido Update(TopicoAtribuido obj);
		void Remove(Guid id);
	}
}