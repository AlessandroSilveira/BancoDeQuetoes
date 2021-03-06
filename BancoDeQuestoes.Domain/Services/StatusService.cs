﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public Status Add(Status obj) => _statusRepository.Add(obj);

        public Status GetById(Guid id) => _statusRepository.GetById(id);

        public IEnumerable<Status> GetAll() => _statusRepository.GetAll();

        public Status Update(Status obj) => _statusRepository.Update(obj);

        public void Remove(Guid obj) => _statusRepository.Remove(obj);

        public void Dispose()
        {
            _statusRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Status ObterDescricaoStatus(string itemSemConfirmaçãoDeAceitePeloElaborador)
        {
            return _statusRepository.ObterDescricaoStatus(a => a.Nome.Equals(itemSemConfirmaçãoDeAceitePeloElaborador));
        }

        public IEnumerable<Status> Search(Expression<Func<Status, bool>> func)
        {
            return _statusRepository.Search(func);
        }
    }
}