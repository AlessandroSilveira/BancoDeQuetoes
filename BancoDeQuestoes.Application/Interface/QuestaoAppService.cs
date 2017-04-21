using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Infra.Data.Repositories;

namespace BancoDeQuestoes.Application.Interface
{
	public class QuestaoAppService : IQuestaoAppService
	{
	    private readonly QuestaoRepository _questaoRepository;

	    public QuestaoAppService(QuestaoRepository questaoRepository)
	    {
	        _questaoRepository = questaoRepository;
	    }

	    public void Dispose()
	    {
	        _questaoRepository.Dispose();

        }

	    public QuestaoViewModel Add(QuestaoViewModel obj)
	    {
	        var questao = Mapper.Map<QuestaoViewModel, Questao>(obj);
	        _questaoRepository.Add(questao);
	        return obj;
        }

	    public QuestaoViewModel GetById(Guid id)
	    {
	        return Mapper.Map<Questao, QuestaoViewModel>(_questaoRepository.GetById(id));
        }

	    public IEnumerable<QuestaoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Questao>, IEnumerable<QuestaoViewModel>>(_questaoRepository.GetAll());
        }

	    public QuestaoViewModel Update(QuestaoViewModel obj)
	    {
	        _questaoRepository.Update(Mapper.Map<QuestaoViewModel, Questao>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
	        _questaoRepository.Remove(id);
        }

	    public IEnumerable<QuestaoViewModel> Search(Expression<Func<QuestaoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	        return _questaoRepository.SaveChanges();
        }
	}
}
