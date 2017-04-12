using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
	public interface IItensPesquisaDisciplina
	{
		List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql);
		IItensPesquisaDisciplina Proximo { get; set; }
	}
}
