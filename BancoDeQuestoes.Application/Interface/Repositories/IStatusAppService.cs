using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
    public interface IStatusAppService : IDisposable
    {
        StatusViewModel Add(StatusViewModel obj);
        StatusViewModel GetById(Guid id);
        IEnumerable<StatusViewModel> GetAll();
        StatusViewModel Update(StatusViewModel obj);
        void Remove(Guid id);
        IEnumerable<StatusViewModel> ObterDescricaoStatus(string itemSemConfirmaçãoDeAceitePeloElaborador);
    }
}