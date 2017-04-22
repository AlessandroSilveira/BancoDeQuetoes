using System;
using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class DisciplinaService : IDisciplinaService
    {
        private IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

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

			//filtroDescTopico.Proximo = filtroIdDisciplina;
			//filtroIdDisciplina.Proximo = filtroDescTitulo;
			//filtroDescTitulo.Proximo = filtroDescBibliografia;
			//filtroDescBibliografia.Proximo = filtroDescNivel;

			////Deixar a classe FimPesquisa sempre por ultimo, ela é que finaliza e retorna a consulta, sem ela dárá um erro
			//filtroDescNivel.Proximo = filtroFimPesquisa;

			return filtroDescTopico.Pesquisa(form, sql);
		}

	    public void Add(Disciplina obj)
	    {
	        _disciplinaRepository.Add(obj);

	    }

	    public Disciplina GetById(Guid id)
	    {
	      return  _disciplinaRepository.GetById(id);

	    }

	    public IEnumerable<Disciplina> GetAll()
	    {
	        return _disciplinaRepository.GetAll();

	    }

	    public void Update(Disciplina obj)
	    {
	        _disciplinaRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _disciplinaRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _disciplinaRepository.Dispose();
            GC.SuppressFinalize(this);

	    }
	}
}
