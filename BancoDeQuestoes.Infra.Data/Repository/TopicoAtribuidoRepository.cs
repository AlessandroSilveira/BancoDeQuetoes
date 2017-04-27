using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaDisciplina;
using BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class TopicoAtribuidoRepositoryBase : RepositoryBase<TopicoAtribuido>, ITopicoAtribuidoRepository
	{
		public IEnumerable<TopicoAtribuido> ExecutadorDePesquisa(TopicoAtribuido form)
		{
			var sql = GetAll().ToList();

			var filtroProjetoId = new ProjetoId();
			var filtroDisciplinaId = new DisciplinaId();
			var filtroAreaId = new AreaId();
			var filtroMestreId = new MestreId();
			var filtroNivel = new Nivel();
			var filtroFimPesquisa = new FimPesquisaTopico();

			filtroProjetoId.Proximo = filtroDisciplinaId;
			filtroDisciplinaId.Proximo = filtroAreaId;
			filtroAreaId.Proximo = filtroMestreId;
			filtroMestreId.Proximo = filtroNivel;

			//Deixar a classe FimPesquisa sempre por ultimo, ela é que finaliza e retorna a consulta, sem ela dará um erro
			filtroNivel.Proximo = filtroFimPesquisa;

			return filtroProjetoId.Pesquisa(form, sql);
		}
	}
}
