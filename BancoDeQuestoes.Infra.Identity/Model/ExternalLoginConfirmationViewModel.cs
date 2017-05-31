using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Infra.Identity.Model
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}