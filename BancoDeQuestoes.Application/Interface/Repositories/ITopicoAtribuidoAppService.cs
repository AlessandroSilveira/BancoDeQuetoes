using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface ITopicoAtribuidoAppService : IDisposable
	{
		TopicoAtribuidoViewModel Add(TopicoAtribuidoViewModel obj);
		TopicoAtribuidoViewModel GetById(Guid id);
		IEnumerable<TopicoAtribuidoViewModel> GetAll();
		TopicoAtribuidoViewModel Update(TopicoAtribuidoViewModel obj);
		void Remove(Guid id);
	    int ObterCodigoProjeto(Guid projetoId);
        IEnumerable<TopicoAtribuidoViewModel> Search(Expression<Func<TopicoAtribuido, bool>> func);
	}
}