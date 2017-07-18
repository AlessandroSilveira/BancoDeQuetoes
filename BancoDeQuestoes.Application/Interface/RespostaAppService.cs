using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface
{
	public class RespostaAppService : ApplicationService, IRespostaAppService
	{
		private readonly IRespostaService _respostaService;
		public RespostaAppService(IRespostaService respostaService, IUnitOfWork uow) : base(uow)
		{
			_respostaService = respostaService;
		}

		public RespostaViewModel Add(RespostaViewModel obj)
		{
			var resposta = Mapper.Map<RespostaViewModel, Resposta>(obj);
			BeginTransaction();
			_respostaService.Add(resposta);
			Commit();
			return obj;
		}

		public RespostaViewModel GetById(Guid id)
		{
			return Mapper.Map<Resposta, RespostaViewModel>(_respostaService.GetById(id));
		}

		public IEnumerable<RespostaViewModel> GetAll()
		{
			return Mapper.Map<IEnumerable<Resposta>, IEnumerable<RespostaViewModel>>(_respostaService.GetAll());
		}

		public RespostaViewModel Update(RespostaViewModel obj)
		{
			BeginTransaction();
			_respostaService.Update(Mapper.Map<RespostaViewModel, Resposta>(obj));
			Commit();
			return obj;
		}

		public void Remove(Guid id)
		{
			BeginTransaction();
			_respostaService.Remove(id);
			Commit();
		}

		public void Dispose()
		{
			_respostaService.Dispose();
		}

		public IEnumerable<RespostaViewModel> Search(Expression<Func<Resposta, bool>> func)
		{
			return
				Mapper.Map<IEnumerable<Resposta>, IEnumerable<RespostaViewModel>>(
					_respostaService.Search(func));
		}
	}
}
