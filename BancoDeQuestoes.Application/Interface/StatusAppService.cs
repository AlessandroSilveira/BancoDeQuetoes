using System;
using System.Collections.Generic;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface
{
    public class StatusAppService : IStatusAppService
    {
        private readonly IStatusService _statusService;

        public StatusAppService(IStatusService statusService)
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
            _statusService.Add(status);
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
            _statusService.Update(Mapper.Map<StatusViewModel, Status>(obj));
            return obj;
        }

        public void Remove(Guid id)
        {
            _statusService.Remove(id);
        }

        public IEnumerable<StatusViewModel> ObterDescricaoStatus(string itemSemConfirmaçãoDeAceitePeloElaborador)
        {
            return
                Mapper.Map<IEnumerable<Status>, IEnumerable<StatusViewModel>>(
                    _statusService.ObterDescricaoStatus(itemSemConfirmaçãoDeAceitePeloElaborador));
        }
    }
}