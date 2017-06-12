using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.ViewModels
{
    public class ConviteMestreViewModel
    {
        public ConviteMestreViewModel()
        {
            ConviteMestreId = new Guid();
        }

        [Key]
        public Guid ConviteMestreId { get; set; }

        public virtual Guid MestreId { get; set; }

        public virtual Guid TopicoAtribuidoId { get; set; }
      
        [DisplayName("Titulo da Disciplina")]
        public int NumeroQuestao { get; set; }

        [DisplayName("Aceito")]
        public bool Aceito { get; set; }

        [DisplayName("Tipo de Pagamento")]
        public string TipoPagamento { get; set; }

        public decimal Valor { get; set; }

        [DisplayName("Data de Aceitação do Convite")]
        public DateTime? DataAceito { get; set; }

        public virtual Mestre Mestre { get; set; }

        public virtual TopicoAtribuido TopicoAtribuido { get; set; }
    }
}