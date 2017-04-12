namespace BancoDeQuestoes.Models
{
    public class PesquisaDisciplinas
    {
       
        public int ID_TOPICO { get; set; }
       
        public int ID_DISCIPLINA { get; set; }
      
        public string DESC_TITULO { get; set; }
  
        public string DESC_TOPICO { get; set; }
       
        public string DESC_BIBLIOGRAFIA { get; set; }
       
        public string DESC_ATIVO { get; set; }
        
        public string DESC_NIVEL { get; set; }

        public int TotalItens { get; set; }
    }
}