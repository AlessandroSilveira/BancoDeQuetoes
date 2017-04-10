using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Mvc.Services.PesquisaDisciplina;

namespace BancoDeQuestoes.Infra.Data.Repositories
{
	public class DisciplinaRepository : BaseRepository<Disciplina>,IDisciplinaRepository

        
	{
		public IEnumerable Cargo()
		{
			return Db.INSCR_BQ_CARGO_CBO.ToList();
		}

		public IEnumerable Area()
		{
			return Db.Area.ToList();
		}

		public IEnumerable ResultadoPesquisaDisciplina(Disciplina form)
		{
			var sql = Db.INSCR_BQ_TOPICO.ToList();

			return ExecutadorDePesquisa(form, sql).ToList();
		}

		private static IEnumerable<Disciplina> ExecutadorDePesquisa(Disciplina form, List<Disciplina> sql)
		{
			var filtroDescTopico = new DescTopico();
			var filtroIdDisciplina = new IdDisciplina();
			var filtroDescTitulo = new DescTitulo();
			var filtroDescBibliografia = new DescBibliografia();
			var filtroDescNivel = new DescNivel();
			var filtroFimPesquisa = new FimPesquisa();

			filtroDescTopico.Proximo = filtroIdDisciplina;
			filtroIdDisciplina.Proximo = filtroDescTitulo;
			filtroDescTitulo.Proximo = filtroDescBibliografia;
			filtroDescBibliografia.Proximo = filtroDescNivel;

			//Deixar a classe FimPesquisa sempre por ultimo, ela é que finaliza e retorna a consulta, sem ela dárá um erro
			filtroDescNivel.Proximo = filtroFimPesquisa;

			return filtroDescTopico.Pesquisa(form, sql);
		}
	}
}