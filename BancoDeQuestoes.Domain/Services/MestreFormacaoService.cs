using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class MestreFormacaoService : IMestreFormacaoService
	{
	    private IMestreFormacaoRepository _mestreFormacaoRepository;

	    public MestreFormacaoService(IMestreFormacaoRepository mestreFormacaoRepository)
	    {
	        _mestreFormacaoRepository = mestreFormacaoRepository;
	    }

	    public MestreFormacao Add(MestreFormacao obj)
	    {
	     return   _mestreFormacaoRepository.Add(obj);

	    }

	    public MestreFormacao GetById(Guid id)
	    {
	    return   _mestreFormacaoRepository.GetById(id);

	    }

	    public IEnumerable<MestreFormacao> GetAll()
	    {
	        return _mestreFormacaoRepository.GetAll();

	    }

	    public MestreFormacao Update(MestreFormacao obj)
	    {
	     return   _mestreFormacaoRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _mestreFormacaoRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _mestreFormacaoRepository.Dispose();
            GC.SuppressFinalize(this);

	    }

		
	}
}
