using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaDisciplina;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class DisciplinaRepositoryBase : RepositoryBase<Disciplina>,IDisciplinaRepository
	{
		public IEnumerable<Disciplina> ExecutadorDePesquisa(Disciplina form)
		{
			var sql = GetAll().ToList();

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

			//Deixar a classe FimPesquisa sempre por ultimo, ela é que finaliza e retorna a consulta, sem ela dará um erro
			filtroDescNivel.Proximo = filtroFimPesquisa;

			return filtroDescTopico.Pesquisa(form, sql);
		}

	    public IEnumerable<Disciplina> ExecutadorDePesquisaAtribuicao(Disciplina form)
	    {
	        var sql = GetAll().ToList();

	        var filtroDisciplinaId = new DisciplinaId();
	        var filtroAreaId = new AreaId();
	        var filtroNome = new Nome();
	        var filtroDescricao = new Descricao();
	        var filtroNivel = new Nivel();

	        var filtroFimPesquisa = new FimPesquisaTopico();

	        filtroDisciplinaId.Proximo = filtroAreaId;
	        filtroAreaId.Proximo = filtroNome;
	        filtroNome.Proximo = filtroDescricao;
	        filtroDescricao.Proximo = filtroNivel;
	        filtroNivel.Proximo = filtroFimPesquisa;

	        //Deixar a classe FimPesquisa sempre por ultimo, ela é que finaliza e retorna a consulta, sem ela dará um erro
	        filtroNivel.Proximo = filtroFimPesquisa;

	        return filtroDisciplinaId.Pesquisa(form,sql);
	    }
    }
}