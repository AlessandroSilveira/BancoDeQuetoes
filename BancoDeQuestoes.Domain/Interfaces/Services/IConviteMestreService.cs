using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
    public interface IConviteMestreService : IDisposable
    {
        ConviteMestre Add(ConviteMestre obj);
        ConviteMestre GetById(Guid id);
        IEnumerable<ConviteMestre> GetAll();
        ConviteMestre Update(ConviteMestre obj);
        void Remove(Guid id);
        IEnumerable<ConviteMestre> Search(Expression<Func<ConviteMestre, bool>> func);

    }
}