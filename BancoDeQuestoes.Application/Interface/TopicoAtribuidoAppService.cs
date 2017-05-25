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
	public class TopicoAtribuidoAppService :  ITopicoAtribuidoAppService
	{
		private readonly ITopicoAtribuidoService _topicoAtribuido;
	    private readonly IProjetoAppService _projetoAppService;

		public TopicoAtribuidoAppService(ITopicoAtribuidoService topicoAtribuido, IProjetoAppService projetoAppService)
		{
		    _topicoAtribuido = topicoAtribuido;
		    _projetoAppService = projetoAppService;
		}

		public void Dispose()
	    {
			_topicoAtribuido.Dispose();
        }

	    public TopicoAtribuidoViewModel Add(TopicoAtribuidoViewModel obj)
	    {
	        var topico = Mapper.Map<TopicoAtribuidoViewModel, TopicoAtribuido>(obj);
			_topicoAtribuido.Add(topico);
	        return obj;
	    }

	    public TopicoAtribuidoViewModel GetById(Guid id)
	    {
	        return Mapper.Map< TopicoAtribuido, TopicoAtribuidoViewModel>(_topicoAtribuido.GetById(id));
	    }

	    public IEnumerable<TopicoAtribuidoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<TopicoAtribuido>, IEnumerable<TopicoAtribuidoViewModel>>(_topicoAtribuido.GetAll());
        }

	    public TopicoAtribuidoViewModel Update(TopicoAtribuidoViewModel obj)
	    {
			_topicoAtribuido.Update(Mapper.Map< TopicoAtribuidoViewModel, TopicoAtribuido>(obj));
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
			_topicoAtribuido.Remove(id);
	    }

	    public IEnumerable<TopicoAtribuidoViewModel> Search(Expression<Func<TopicoAtribuidoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int ObterCodigoProjeto(Guid projetoId)
	    {
	        var projeto = _projetoAppService.GetById(projetoId);
	        return projeto.CodigoProjeto;
	    }
	}
}