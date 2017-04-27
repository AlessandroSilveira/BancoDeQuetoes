using System;
using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;



namespace BancoDeQuestoes.Domain.Services
{
	public class DisciplinaService : IDisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        public IEnumerable<Disciplina> ResultadoPesquisaDisciplina(Disciplina form)
        {
	       return  _disciplinaRepository.ExecutadorDePesquisa(form);
        }
		
	    public Disciplina Add(Disciplina obj)
	    {
	      return  _disciplinaRepository.Add(obj);
	    }

	    public Disciplina GetById(Guid id)
	    {
	      return  _disciplinaRepository.GetById(id);
	    }

	    public IEnumerable<Disciplina> GetAll()
	    {
	        return _disciplinaRepository.GetAll();
	    }

	    public Disciplina Update(Disciplina obj)
	    {
	     return  _disciplinaRepository.Update(obj);
	    }

	    public void Remove(Guid obj)
	    {
	        _disciplinaRepository.Remove(obj);
        }

	    public void Dispose()
	    {
	        _disciplinaRepository.Dispose();
            GC.SuppressFinalize(this);
	    }
    }
}
