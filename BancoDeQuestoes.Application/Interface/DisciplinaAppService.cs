using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

using BancoDeQuestoes.Infra.Data.Repository;

namespace BancoDeQuestoes.Application.Interface
{
	public class DisciplinaAppService : IDisciplinaAppService
	{

	    private readonly DisciplinaRepository _disciplinaRepository;

	    public DisciplinaAppService(DisciplinaRepository disciplinaRepository)
	    {
	        _disciplinaRepository = disciplinaRepository;
	    }

        public DisciplinaViewModel Add(DisciplinaViewModel obj)
	    {
	        var disciplina = Mapper.Map<DisciplinaViewModel, Disciplina>(obj);
	        _disciplinaRepository.Add(disciplina);
	        return obj;
        }

	    public DisciplinaViewModel GetById(Guid id)
	    {
	        return Mapper.Map<Disciplina, DisciplinaViewModel>(_disciplinaRepository.GetById(id));
        }

	    public IEnumerable<DisciplinaViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(_disciplinaRepository.GetAll());
        }

	    public DisciplinaViewModel Update(DisciplinaViewModel obj)
	    {
	        _disciplinaRepository.Update(Mapper.Map<DisciplinaViewModel, Disciplina>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
	        _disciplinaRepository.Remove(id);
        }

	    public IEnumerable<DisciplinaViewModel> Search(Expression<Func<DisciplinaViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	        return _disciplinaRepository.SaveChanges();
	    }

	    public IEnumerable<RevisorFormacaoViewModel> ResultadoPesquisaDisciplina(RevisorFormacaoViewModel form)
	    {
	        throw new NotImplementedException();
	    }

	    public void Dispose()
	    {
	        _disciplinaRepository.Dispose();
	    }
    }
}
