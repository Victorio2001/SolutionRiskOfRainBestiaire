using System.ComponentModel.DataAnnotations;

namespace RiskOfRain.Web.ViewsModels.Account;

public class ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}