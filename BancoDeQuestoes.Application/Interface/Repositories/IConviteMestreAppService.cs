using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
    public interface IConviteMestreAppService : IDisposable
    {
        ConviteMestreViewModel Add(ConviteMestreViewModel obj);
        ConviteMestreViewModel GetById(Guid id);
        IEnumerable<ConviteMestreViewModel> GetAll();
        ConviteMestreViewModel Update(ConviteMestreViewModel obj);
        void Remove(Guid id);
        IEnumerable<ConviteMestreViewModel> Search(Expression<Func<ConviteMestre, bool>> func);
        void Detach(ConviteMestreViewModel dadosConvite);
    }
}