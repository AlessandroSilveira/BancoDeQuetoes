using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
    public class ProjetoRepository :BaseRepository, IProjetoRepository
    {
        public List<INSCR_BQ_PROJETO> List()
        {
         return _db.INSCR_BQ_PROJETO.ToList();
        }

        public INSCR_BQ_PROJETO Find(int? id)
        {
            return _db.INSCR_BQ_PROJETO.Find(id);
        }

        public void Add(INSCR_BQ_PROJETO iNscrBqProjeto)
        {
            _db.INSCR_BQ_PROJETO.Add(iNscrBqProjeto);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
		
        public void Remove(INSCR_BQ_PROJETO iNscrBqProjeto)
        {
            _db.INSCR_BQ_PROJETO.Remove(iNscrBqProjeto);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

	    public void Update(INSCR_BQ_PROJETO iNscrBqProjeto)
	    {
			 _db.Entry(iNscrBqProjeto).State = EntityState.Modified;
		}
	}
}