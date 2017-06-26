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
    public class StatusAppService : ApplicationService, IStatusAppService
	{
		private readonly IStatusService _statusService;

		public StatusAppService(IStatusService statusService, IUnitOfWork uow) : base(uow)
        {
			_statusService = statusService;
		}

		public void Dispose()
	    {
			_statusService.Dispose();
	    }

	    public StatusViewModel Add(StatusViewModel obj)
	    {
	        var status = Mapper.Map<StatusViewModel, Status>(obj);
            BeginTransaction();
			_statusService.Add(status);
            Commit();
	        return obj;
	    }

	    public StatusViewModel GetById(Guid id)
	    {
	        return Mapper.Map<Status, StatusViewModel>(_statusService.GetById(id));
        }

	    public IEnumerable<StatusViewModel> GetAll()
	    {
            return Mapper.Map<IEnumerable<Status>, IEnumerable<StatusViewModel>>(_statusService.GetAll());
        }

	    public StatusViewModel Update(StatusViewModel obj)
	    {
            BeginTransaction();
			_statusService.Update(Mapper.Map<  StatusViewModel, Status>(obj));
            Commit();
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
            BeginTransaction();
			_statusService.Remove(id);
            Commit();
	    }

	    public StatusViewModel ObterDescricaoStatus(string itemSemConfirmaçãoDeAceitePeloElaborador)
	    {
            return Mapper.Map<Status, StatusViewModel>(_statusService.ObterDescricaoStatus(itemSemConfirmaçãoDeAceitePeloElaborador));
	    }

	    public IEnumerable<StatusViewModel> Search(Expression<Func<Status, bool>> func)
	    {
	        return Mapper.Map<IEnumerable<Status>, IEnumerable<StatusViewModel>>(_statusService.Search(func));
        }
	}
}