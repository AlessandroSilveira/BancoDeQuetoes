﻿using System.Net.Configuration;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Banca
	{
		public int BancaId { get; set; }
		public string Nome { get; set; }
		public decimal Valor{get; set; }
		public bool Ativo { get; set; }
	}
}
