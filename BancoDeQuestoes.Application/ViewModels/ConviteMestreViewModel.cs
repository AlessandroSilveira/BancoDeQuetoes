using System;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.ViewModels
{
    public class ConviteMestreViewModel
    {
        public ConviteMestreViewModel()
        {
            ConviteMestreId = new Guid();
        }

        public Guid ConviteMestreId { get; set; }

        public virtual Guid MestreId { get; set; }

        public virtual Guid TopicoAtribuidoId { get; set; }

        public int NumeroQuestao { get; set; }

        public bool Aceito { get; set; }

        public string TipoPagamento { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataAceito { get; set; }

        public virtual Mestre Mestre { get; set; }

        public virtual TopicoAtribuido TopicoAtribuido { get; set; }
    }
}