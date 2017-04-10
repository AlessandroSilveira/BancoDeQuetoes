using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Services;
using BancoDeQuestoes.Services.PesquisaDisciplina;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Infra.Data.Repositories
{
    public class DisciplinaRepository : BaseRepository<INSCR_BQ_TOPICO>,IDisciplinaRepository

        
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

		private static IEnumerable<INSCR_BQ_TOPICO> ExecutadorDePesquisa(INSCR_BQ_TOPICO form, List<INSCR_BQ_TOPICO> sql)
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