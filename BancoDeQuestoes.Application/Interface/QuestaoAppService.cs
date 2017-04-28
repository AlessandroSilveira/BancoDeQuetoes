using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface
{
	public class QuestaoAppService : IQuestaoAppService
	{
		private readonly IQuestaoService _questaoService;

		public QuestaoAppService(IQuestaoService questaoService)
		{
			_questaoService = questaoService;
		}

		public void Dispose()
	    {
			_questaoService.Dispose();
        }

	    public QuestaoViewModel Add(QuestaoViewModel obj)
	    {
	        var questao = Mapper.Map<QuestaoViewModel, Questao>(obj);
			_questaoService.Add(questao);
	        return obj;
        }

	    public QuestaoViewModel GetById(Guid id)
	    {
	        return Mapper.Map<Questao, QuestaoViewModel>(_questaoService.GetById(id));
        }

	    public IEnumerable<QuestaoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Questao>, IEnumerable<QuestaoViewModel>>(_questaoService.GetAll());
        }

	    public QuestaoViewModel Update(QuestaoViewModel obj)
	    {
			_questaoService.Update(Mapper.Map<QuestaoViewModel, Questao>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
			_questaoService.Remove(id);
        }

	    public IEnumerable<QuestaoViewModel> Search(Expression<Func<QuestaoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }
	}
}
