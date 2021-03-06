﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
    public interface IUsuarioService : IDisposable
    {
        Usuario Add(Usuario obj);
        Usuario GetById(Guid id);
        IEnumerable<Usuario> GetAll();
        Usuario Update(Usuario obj);
        void Remove(Guid id);
        IEnumerable<Usuario> Search(Expression<Func<Usuario, bool>> func);
        void DesativarLock(Guid id);
    }
}