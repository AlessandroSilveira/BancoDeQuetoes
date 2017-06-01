using System;
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


        public void DesativarLock(Guid id)
        {
            GetById(id).LockoutEnabled = false;
            SaveChanges();
        }
    }
}