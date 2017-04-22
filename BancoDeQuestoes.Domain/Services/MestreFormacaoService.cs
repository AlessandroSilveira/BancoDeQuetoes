using System;
using System.Collections.Generic;
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

	    public void Add(MestreFormacao obj)
	    {
	        _mestreFormacaoRepository.Add(obj);

	    }

	    public MestreFormacao GetById(Guid id)
	    {
	    return   _mestreFormacaoRepository.GetById(id);

	    }

	    public IEnumerable<MestreFormacao> GetAll()
	    {
	        return _mestreFormacaoRepository.GetAll();

	    }

	    public void Update(MestreFormacao obj)
	    {
	        _mestreFormacaoRepository.Update(obj);

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
