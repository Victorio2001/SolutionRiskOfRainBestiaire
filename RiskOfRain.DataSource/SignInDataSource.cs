using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RiskOfRain.Model.Identity;
using RiskOfRain.DataSource.interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace RiskOfRain.DataSource;

public class SignInDataSource : SignInManager<User>
{
    public SignInDataSource(UserManager<User> userManager, IHttpContextAccessor contextAccessor, 
        IUserClaimsPrincipalFactory<User> claimsFactory, 
        IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<User>> logger, 
        IAuthenticationSchemeProvider schemes, IUserConfirmation<User> confirmation) : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)
    {
    }
}