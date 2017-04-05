using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
    public interface IProjetoRepository
    {
        List<INSCR_BQ_PROJETO> List();
        INSCR_BQ_PROJETO Find(int? id);
        void Add(INSCR_BQ_PROJETO iNscrBqProjeto);
        void SaveChanges();
	    void Update(INSCR_BQ_PROJETO iNscrBqProjeto);
        //DbEntityEntry<INSCR_BQ_PROJETO> Entry(INSCR_BQ_PROJETO iNscrBqProjeto);
        void Remove(INSCR_BQ_PROJETO iNscrBqProjeto);
        void Dispose();
    }
}