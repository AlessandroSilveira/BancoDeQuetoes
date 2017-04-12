using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
	public interface IItensPesquisaDisciplina
	{
		List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql);
		IItensPesquisaDisciplina Proximo { get; set; }
	}
}
