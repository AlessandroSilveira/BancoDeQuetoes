using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
    public class AreaRepository : BaseRepository , IAreaRepository
    {
        public List<INSCR_BQ_DISCIPLINA> List()
        {
            return _db.INSCR_BQ_DISCIPLINA.ToList();
        }

        public INSCR_BQ_DISCIPLINA Find(int? id)
        {
            return _db.INSCR_BQ_DISCIPLINA.Find(id);
        }

        public void Add(INSCR_BQ_DISCIPLINA iNscrBqDisciplina)
        {
            _db.INSCR_BQ_DISCIPLINA.Add(iNscrBqDisciplina);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public DbEntityEntry<INSCR_BQ_DISCIPLINA> Entry(INSCR_BQ_DISCIPLINA iNscrBqDisciplina)
        {
            return _db.Entry(iNscrBqDisciplina);
        }

        public void Remove(INSCR_BQ_DISCIPLINA iNscrBqDisciplina)
        {
            _db.INSCR_BQ_DISCIPLINA.Remove(iNscrBqDisciplina);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}