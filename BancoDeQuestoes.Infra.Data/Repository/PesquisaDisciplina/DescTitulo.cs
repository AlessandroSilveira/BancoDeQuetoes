using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository.PesquisaDisciplina
{
    public class DescTitulo : IItensPesquisaDisciplina
	{
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			if (string.IsNullOrEmpty(form.Nome)) return Proximo.Pesquisa(form, sql);
			sql = sql.Where(a => a.Nome == form.Nome).ToList();
			return Proximo.Pesquisa(form, sql);
		}
		public IItensPesquisaDisciplina Proximo { get; set; }
	}
}