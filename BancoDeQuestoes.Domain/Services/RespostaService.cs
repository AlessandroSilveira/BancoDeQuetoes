using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class RespostaService : IRespostaService
	{
		private readonly IRespostaRepository _respostaRepository;

		public RespostaService(IRespostaRepository respostaRepository)
		{
			_respostaRepository = respostaRepository;
		}

		public Resposta Add(Resposta obj)
		{
			return _respostaRepository.Add(obj);
		}

		public Resposta GetById(Guid id)
		{
			return _respostaRepository.GetById(id);
		}

		public IEnumerable<Resposta> GetAll()
		{
			return _respostaRepository.GetAll();
		}

		public Resposta Update(Resposta obj)
		{
			return _respostaRepository.Add(obj);
		}

		public void Remove(Guid obj)
		{
			_respostaRepository.Remove(obj);
		}

		public IEnumerable<Resposta> Search(Expression<Func<Resposta, bool>> func)
		{
			return _respostaRepository.Search(func);
		}

		public void Dispose()
		{
			_respostaRepository.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
