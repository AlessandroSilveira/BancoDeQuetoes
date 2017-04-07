using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Services.PesquisaDisciplina;

namespace BancoDeQuestoes.Repositories
{
    public class MestreRepository : BaseRepository<INSCR_BQ_MESTRE>, IMestreRepository
    {
        List<INSCR_BQ_MESTRE> IMestreRepository.Include()
        {
            return Db.INSCR_BQ_MESTRE.Include(i => i.INSCR_BQ_BANCA).ToList();
        }

	    public IEnumerable<INSCR_BQ_MESTRE> ResultadoPesquisaMestre(INSCR_BQ_MESTRE form)
	    {
			var sql = Db.INSCR_BQ_MESTRE.ToList();

			return ExecutadorDePesquisaMestres(form, sql).ToList();
		}

	    private  static IEnumerable<INSCR_BQ_MESTRE>  ExecutadorDePesquisaMestres(INSCR_BQ_MESTRE form, List<INSCR_BQ_MESTRE> sql)
	    {
			var filtroNomeMestre = new NomeMestre();
			var filtroStatusMestre = new StatusMestre();
			var filtroFimPesquisa = new FimPesquisaMestre();

			filtroNomeMestre.Proximo = filtroStatusMestre;
			filtroStatusMestre.Proximo = filtroFimPesquisa;
			
			return filtroNomeMestre.Pesquisa(form, sql);
		}
    }
}