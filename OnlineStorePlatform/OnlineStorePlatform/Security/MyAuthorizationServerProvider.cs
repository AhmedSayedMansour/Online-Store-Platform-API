using Microsoft.Owin.Security.OAuth;
using OnlineStorePlatform.Controllers;
using OnlineStorePlatform.DBContext;
using System.Security.Claims;
using System.Threading.Tasks;
namespace TokenAuthenticationInWebAPI.Models
{
    public class MyAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            context.Validated();
        }
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            using (AccountController _repo = new AccountController())
            {
                var user = _repo.Login(context.UserName, context.Password);
                if (user == null)
                {
                    context.SetError("invalid_grant", "Provided username and password is incorrect");
                    return;
                }
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Role, user.type));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.userName));
                identity.AddClaim(new Claim(ClaimTypes.Email, user.email));
                context.Validated(identity);
            }
          
            
        }
    }
}