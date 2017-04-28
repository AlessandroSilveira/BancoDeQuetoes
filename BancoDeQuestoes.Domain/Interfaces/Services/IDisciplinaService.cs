using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IDisciplinaService : IDisposable
	{
		Disciplina Add(Disciplina obj);
		Disciplina GetById(Guid id);
		IEnumerable<Disciplina> GetAll();
		Disciplina Update(Disciplina obj);
		void Remove(Guid id);
		IEnumerable<Disciplina> ResultadoPesquisaDisciplina(Disciplina disciplina);
	    IEnumerable<Disciplina> ResultadoPesquisaDisciplinaAtribuicao(Disciplina topico);
    }
}
