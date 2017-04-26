using System;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
    public class ProjetoRepositoryBase : RepositoryBase<Projeto>, IProjetoRepository
    {
	    //public override void Remove(Guid id)
	    //{
		   // var projeto = new Projeto() {ProjetoId = id};
		   // DbSet.Remove(projeto);
	    //}
    }
}