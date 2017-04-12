namespace BancoDeQuestoes.Domain.Entities
{
	public class Questao
	{
		public int QuestaoId { get; set; }
		public int TopicoAtribuidoId { get; set; }
		public int NumeroQuestao { get; set; }
		public string Descricao { get; set; }
		public string Arquivo { get; set; }
		public string Status { get; set; }
		public int NumeroDeRevisoes { get; set; }
		public int Finalizar { get; set; }
		public string Nivel { get; set; }
		public string Imagem { get; set; }
		public bool ConviteAceito { get; set; }

		public virtual TopicoAtribuido TopicoAtribuido { get; set; }
	}
}
