using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class TopicoAtribuidoRepositoryBase : RepositoryBase<TopicoAtribuido>, ITopicoAtribuidoRepository
	{
		public IEnumerable<Disciplina> ExecutadorDePesquisa(Disciplina form , IEnumerable<Disciplina> todos)
		{
			//var sql = GetAll().ToList();

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

			return filtroDisciplinaId.Pesquisa(form, todos);
		}
	}
}
