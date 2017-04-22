using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class QuestaoService :  IQuestaoService
	{
	    private IQuestaoRepository _questaoRepository;

	    public QuestaoService(IQuestaoRepository questaoRepository)
	    {
	        _questaoRepository = questaoRepository;
	    }

	    public void Add(Questao obj)
	    {
	        _questaoRepository.Add(obj);

	    }

	    public Questao GetById(Guid id)
	    {
	     return   _questaoRepository.GetById(id);

	    }

	    public IEnumerable<Questao> GetAll()
	    {
	        return _questaoRepository.GetAll();

	    }

	    public void Update(Questao obj)
	    {
	        _questaoRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _questaoRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _questaoRepository.Dispose();
            GC.SuppressFinalize(this);

	    }

	    public IEnumerable<Questao> GetListaGerenciamentoQuestao()
	    {
	        throw new NotImplementedException();
	    }
	}
}