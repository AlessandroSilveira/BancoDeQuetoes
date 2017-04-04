using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Repositories;

namespace BancoDeQuestoes.Services
{
    public class PesquisarDisciplinas :BaseRepository
    {
        public string Area { get; set; }
        public string Nivel { get; set; }
        public string Disciplina { get; set; }
        public string Descricao { get; set; }
        public string Biblioteca { get; set; }
        public int TotalPagina { get; set; }


        public List<INSCR_BQ_DISCIPLINA> ListaDisciplinas()
        {
            return _db.INSCR_BQ_DISCIPLINA.ToList();
        }
    }
}