using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Services;
using BancoDeQuestoes.Services.PesquisaDisciplina;

namespace BancoDeQuestoes.Repositories
{
	public class DisciplinaRepository : BaseRepository<INSCR_BQ_TOPICO>, IDisciplinaRepository
	{
		public IEnumerable Cargo()
		{
			return Db.INSCR_BQ_CARGO_CBO.ToList();
		}

		public IEnumerable Area()
		{
			return Db.INSCR_BQ_DISCIPLINA.ToList();
		}

		public IEnumerable ResultadoPesquisaDisciplina(INSCR_BQ_TOPICO form)
		{
			var sql = Db.INSCR_BQ_TOPICO.ToList();

			return ExecutadorDePesquisa(form, sql).ToList();
		}

		private static List<INSCR_BQ_TOPICO> ExecutadorDePesquisa(INSCR_BQ_TOPICO form, List<INSCR_BQ_TOPICO> sql)
		{
			var executaPesquisa = new ExecutaPesquisaDisciplina();

			return executaPesquisa.Executa(ItensPesquisaDisciplinas(), sql, form);
		}

		private static IList<IItensPesquisaDisciplina> ItensPesquisaDisciplinas()
		{
			var itensPesquisa = new ItensPesquisaDusciplina();
			IList<IItensPesquisaDisciplina> itensPesquisaDisciplinas = new List<IItensPesquisaDisciplina>()
			{
				itensPesquisa.Pega("DESC_TOPICO"),
				itensPesquisa.Pega("ID_DISCIPLINA"),
				itensPesquisa.Pega("DESC_TOPICO"),
				itensPesquisa.Pega("DESC_BIBLIOGRAFIA"),
				itensPesquisa.Pega("DESC_TOPICO"),
				itensPesquisa.Pega("DESC_NIVEL")
			};
			return itensPesquisaDisciplinas;
            
		}
	}
}