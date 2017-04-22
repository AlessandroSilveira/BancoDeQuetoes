using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    

    public class FormacaoRevisorService : IFormacaoRevisorService
    {
        private readonly IFormacaoRevisoresRepository _formacaoRevisoresRepository;

        public FormacaoRevisorService(IFormacaoRevisoresRepository formacaoRevisoresRepository)
        {
            _formacaoRevisoresRepository = formacaoRevisoresRepository;
        }

        public void Add(RevisorFormacao obj)
        {
            _formacaoRevisoresRepository.Add(obj);

        }

	    public RevisorFormacao GetById(Guid id)
	    {
	     return   _formacaoRevisoresRepository.GetById(id);

	    }

	    public IEnumerable<RevisorFormacao> GetAll()
	    {
         return   _formacaoRevisoresRepository.GetAll();

	    }

	    public void Update(RevisorFormacao obj)
	    {
	        _formacaoRevisoresRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _formacaoRevisoresRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _formacaoRevisoresRepository.Dispose();
            GC.SuppressFinalize(this);

	    }
	}
}
