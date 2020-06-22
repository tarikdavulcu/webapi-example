using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace WebApi.Authentication
{
    public class Saglayici : OAuthAuthorizationServerProvider
    {

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }


        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            //login kontrolü yspacak yer 
            Models.User user = new Models.User();

            user = Models.Login.login(context.UserName, context.Password);
            if (user.UserID != null && user.UserName != null)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim("name",user.UserName));
                identity.AddClaim(new Claim("userID",user.UserID));
                context.Validated(identity);
            }
            else
            {
                context.SetError("Kullanıcı Girişi Bşarısız..");
            }

        }
    }
}