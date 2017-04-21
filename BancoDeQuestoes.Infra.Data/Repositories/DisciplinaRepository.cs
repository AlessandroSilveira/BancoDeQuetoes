using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Infra.Data.Repositories
{
	public class DisciplinaRepository : Repository<Disciplina>,IDisciplinaRepository
	{

		public IEnumerable Area()
		{
			return Db.Area.ToList();
		}

		public IEnumerable<Disciplina> ResultadoPesquisaDisciplina(Disciplina form)
		{
			var sql = Db.Disciplina.ToList();

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