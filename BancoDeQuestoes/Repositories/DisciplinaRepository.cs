using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Services;

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

		public IEnumerable GetAll(INSCR_BQ_TOPICO form)
		{
			var sql = Db.INSCR_BQ_TOPICO.ToList();

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

			var executa = new ExecutaPesquisaDisciplina();
			sql = executa.Executa(itensPesquisaDisciplinas, sql, form);

			return sql.ToList();
		}
	}
}