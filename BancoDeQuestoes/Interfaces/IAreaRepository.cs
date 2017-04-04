using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
    public interface IAreaRepository
    {
        List<INSCR_BQ_DISCIPLINA> List();
        INSCR_BQ_DISCIPLINA Find(int? id);
        void Add(INSCR_BQ_DISCIPLINA iNscrBqDisciplina);
        void SaveChanges();
        DbEntityEntry<INSCR_BQ_DISCIPLINA> Entry(INSCR_BQ_DISCIPLINA iNscrBqDisciplina);
        void Remove(INSCR_BQ_DISCIPLINA iNscrBqDisciplina);
        void Dispose();
    }
}