using System.ComponentModel.DataAnnotations;

namespace RiskOfRain.Web.ViewsModels.Account;

public class ExternalLoginConfirmationViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}