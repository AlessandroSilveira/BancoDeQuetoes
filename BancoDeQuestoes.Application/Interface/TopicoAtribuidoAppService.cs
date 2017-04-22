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
	public class TopicoAtribuidoAppService :  ITopicoAtribuidoAppService
	{
	    private readonly TopicoAtribuidoRepository _topicoAtribuidoRepository;

	    public TopicoAtribuidoAppService(TopicoAtribuidoRepository topicoAtribuidoRepository)
	    {
	        _topicoAtribuidoRepository = topicoAtribuidoRepository;
	    }

	    public void Dispose()
	    {
	        _topicoAtribuidoRepository.Dispose();

        }

	    public TopicoAtribuidoViewModel Add(TopicoAtribuidoViewModel obj)
	    {
	        var topico = Mapper.Map<TopicoAtribuidoViewModel, TopicoAtribuido>(obj);
	        _topicoAtribuidoRepository.Add(topico);
	        return obj;
	    }

	    public TopicoAtribuidoViewModel GetById(Guid id)
	    {
	        return Mapper.Map< TopicoAtribuido, TopicoAtribuidoViewModel>(_topicoAtribuidoRepository.GetById(id));
	    }

	    public IEnumerable<TopicoAtribuidoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<TopicoAtribuido>, IEnumerable<TopicoAtribuidoViewModel>>(_topicoAtribuidoRepository.GetAll());
        }

	    public TopicoAtribuidoViewModel Update(TopicoAtribuidoViewModel obj)
	    {
	         _topicoAtribuidoRepository.Update(Mapper.Map< TopicoAtribuidoViewModel, TopicoAtribuido>(obj));
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
	        _topicoAtribuidoRepository.Remove(id);
	    }

	    public IEnumerable<TopicoAtribuidoViewModel> Search(Expression<Func<TopicoAtribuidoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	        return _topicoAtribuidoRepository.SaveChanges();
	    }
	}
}