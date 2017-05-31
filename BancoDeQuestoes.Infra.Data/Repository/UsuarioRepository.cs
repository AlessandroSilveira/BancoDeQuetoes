using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Db context) : base(context)
        {
        }
        public void DesativarLock(string id)
        {
            throw new NotImplementedException();
        }
    }
}