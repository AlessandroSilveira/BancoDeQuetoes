using System;

namespace BancoDeQuestoes.Domain.Entities
{
    public class ConviteMestre
    {

        public ConviteMestre()
        {
            ConviteMestreId = new Guid();
        }

        public  Guid ConviteMestreId { get; set; }

        public virtual Guid MestreId { get; set; }

        public virtual Guid TopicoAtribuidoId { get; set; }

        public int NumeroQuestao { get; set; }

        public bool Aceito { get; set; }

        public string TipoPagamento { get; set; }

        public decimal Valor { get; set; }

        public DateTime? DataAceito { get; set; }

        public virtual Mestre Mestre { get; set; }

        public virtual TopicoAtribuido TopicoAtribuido { get; set; }
    }
}
