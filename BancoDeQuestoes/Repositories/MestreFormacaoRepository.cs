using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
	public class MestreFormacaoRepository : BaseRepository<INSCR_BQ_MESTRE_FORMACAO>, IMestreFormacaoRepository
	{
		public List<INSCR_BQ_MESTRE_FORMACAO> Include()
		{
			
				return Db.INSCR_BQ_MESTRE_FORMACAO.Include(i => i.INSCR_BQ_MESTRE).ToList();
			}
		
	}
}