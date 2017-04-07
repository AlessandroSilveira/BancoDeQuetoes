using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
    public class MestreRepository : BaseRepository<INSCR_BQ_MESTRE>, IMestreRepository
    {
        List<INSCR_BQ_MESTRE> IMestreRepository.Include()
        {
            return Db.INSCR_BQ_MESTRE.Include(i => i.INSCR_BQ_BANCA).ToList();
        }
    }
}