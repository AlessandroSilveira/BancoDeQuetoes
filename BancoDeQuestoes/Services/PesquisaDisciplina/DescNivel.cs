﻿using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Services
{
	internal class DescNivel : IItensPesquisaDisciplina
	{
		public List<INSCR_BQ_TOPICO> Pesquisa(INSCR_BQ_TOPICO form, List<INSCR_BQ_TOPICO> sql)
		{
			if (!string.IsNullOrEmpty(form.DESC_NIVEL))
			{
				sql = sql.Where(a => a.DESC_NIVEL == form.DESC_NIVEL).ToList();
			}

			return sql.ToList();
		}
	}
}