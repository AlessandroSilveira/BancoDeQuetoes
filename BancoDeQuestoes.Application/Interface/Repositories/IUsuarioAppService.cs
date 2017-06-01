using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
    public interface IUsuarioAppService : IDisposable
    {
        UsuarioViewModel Add(UsuarioViewModel obj);
        UsuarioViewModel GetById(Guid id);
        IEnumerable<UsuarioViewModel> GetAll();
        UsuarioViewModel Update(UsuarioViewModel obj);
        void Remove(Guid id);
        IEnumerable<UsuarioViewModel> Search(Expression<Func<Usuario, bool>> func);
        void DesativarLock(Guid id);
    }
}