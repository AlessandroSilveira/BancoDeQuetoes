namespace BancoDeQuestoes.Services
{
    public class PesquisarDisciplinas 
    {
        public string Area { get; set; }
        public string Nivel { get; set; }
        public string Disciplina { get; set; }
        public string Descricao { get; set; }
        public string Biblioteca { get; set; }
        public int TotalPagina { get; set; }


        //public List<INSCR_BQ_DISCIPLINA> ListaDisciplinas()
        //{
        //    return _db.INSCR_BQ_DISCIPLINA.ToList();
        //}
    }
}