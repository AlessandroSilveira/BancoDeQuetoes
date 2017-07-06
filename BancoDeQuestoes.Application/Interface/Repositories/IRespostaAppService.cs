using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IRespostaAppService
	{
		RespostaViewModel Add(RespostaViewModel obj);
		RespostaViewModel GetById(Guid id);
		IEnumerable<RespostaViewModel> GetAll();
		RespostaViewModel Update(RespostaViewModel obj);
		void Remove(Guid id);
		IEnumerable<RespostaViewModel> Search(Expression<Func<Resposta, bool>> func);
	}
}
