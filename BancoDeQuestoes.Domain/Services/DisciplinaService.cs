﻿using System;
using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Infra.Data.Repositories;

namespace BancoDeQuestoes.Domain.Services
{
	public class DisciplinaService : ServiceBase<Disciplina>, IDisciplinaService
	{
		public DisciplinaService(IRepositoryBase<Disciplina> repositoryBase) : base(repositoryBase)
		{
		}

		//public void Dispose()
		//{
		//	throw new NotImplementedException();
		//}

		public IEnumerable<Disciplina> ResultadoPesquisaDisciplina(Disciplina form)
		{
			var sql = GetAll().ToList();

			return ExecutadorDePesquisa(form, sql).ToList();
		}

		private static IEnumerable<Disciplina> ExecutadorDePesquisa(Disciplina form, List<Disciplina> sql)
		{
			//todo refazer essa pesquisa usando expressao lambda como sugerido pelo vlad

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
