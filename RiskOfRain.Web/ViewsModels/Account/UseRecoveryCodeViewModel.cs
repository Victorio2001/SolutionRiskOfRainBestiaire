using System.ComponentModel.DataAnnotations;

namespace RiskOfRain.Web.ViewsModels.Account;

public class UseRecoveryCodeViewModel
{
    [Required]
    public string Code { get; set; }

    public string ReturnUrl { get; set; }
}