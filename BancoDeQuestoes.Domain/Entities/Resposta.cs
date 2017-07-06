﻿using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public class Resposta
	{
		public Resposta()
		{
			RespostaId = Guid.NewGuid();
		}

		public Guid RespostaId { get; set; }
		public Guid TopicoAtribuidoId { get; set; }
		public Guid QuestaoId { get; set; }
		public string Descricao { get; set; }
		public string Correcao { get; set; }
		public string Justificativa { get; set; }
		public string Status { get; set; }
		public string ObservacaoRevisor { get; set; }
		public string ObservacaoRevisor2 { get; set; }
		public string Imagem { get; set; }
		public string ImagemJustificativa { get; set; }
	}
}