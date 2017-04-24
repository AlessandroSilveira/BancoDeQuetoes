using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class TopicoAtribuidoService : ITopicoAtribuidoService
    {

        private readonly ITopicoAtribuidoRepository _topicoAtribuidoRepository;

        public TopicoAtribuidoService(ITopicoAtribuidoRepository topicoAtribuidoRepository)
        {
            _topicoAtribuidoRepository = topicoAtribuidoRepository;
        }


        public TopicoAtribuido Add(TopicoAtribuido obj)
        {
          return  _topicoAtribuidoRepository.Add(obj);

        }

	    public TopicoAtribuido GetById(Guid id)
	    {
	      return  _topicoAtribuidoRepository.GetById(id);

	    }

	    public IEnumerable<TopicoAtribuido> GetAll()
	    {

	        return _topicoAtribuidoRepository.GetAll();

	    }

	    public TopicoAtribuido Update(TopicoAtribuido obj)
	    {
	     return   _topicoAtribuidoRepository.Add(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _topicoAtribuidoRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _topicoAtribuidoRepository.Dispose();
            GC.SuppressFinalize(this);
	    }

	  
    }
}