﻿using System;
using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Mestre
	{

		public Mestre()
		{
			MestreId = Guid.NewGuid();
		}

		public Guid MestreId { get; set; }
		public string Cpf { get; set; }
		public string Nome { get; set; }
		public string Cep { get; set; }
		public string Endereco { get; set; }
		public string Complemento { get; set; }
		public string Numero { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string Email { get; set; }
		public string EmailSecundario { get; set; }
		public string Telefone { get; set; }
		public string Celular { get; set; }
		public Guid BancaId { get; set; }
		public string Filhos { get; set; }
		public string Pis { get; set; }
		public string Minicurriculo { get; set; }
		public string Banco { get; set; }
		public string Agencia { get; set; }
		public string TipoConta { get; set; }
		public string Conta { get; set; }
		public bool Ativo { get; set; }

		public virtual Banca Banca { get; set; }

		public virtual ICollection<MestreArea> MestreAreas { get; set; } = new List<MestreArea>();
		public virtual ICollection<MestreFormacao> MestreFormacaos { get; set; } = new List<MestreFormacao>();
		public virtual ICollection<MestreDependente> MestreDependentes { get; set; } = new List<MestreDependente>();
		public virtual ICollection<TopicoAtribuido> TopicoAtribuidos { get; set; } = new List<TopicoAtribuido>();
	}
}
