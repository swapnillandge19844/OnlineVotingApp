using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OnlineVotingApp.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingApp.Services
{
    public class AuthenticateService:IAuthenticateService
    {
        public AppSettings _appSettings;
        public AuthenticateService(IOptions<AppSettings> appsettings)
        {
            _appSettings = appsettings.Value;
        }

        private List<User> users = new List<User>()
        {
            new User
            {
                UserId=1,FirstName="Swapnil",LastName="Landge",UserName="815833509922",Password="9881518407"
            }

        };

        public User Authenticate(string userName, string password)
        {
            var user = users.SingleOrDefault(x => x.UserName == userName && x.Password == password);

            //Return null if user not found
            if (user == null)
                return null;

            //if user found
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Key);
            var tokenDiscriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString()),
                    new Claim(ClaimTypes.Role, "Admin")
                }),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDiscriptor);
            user.Token = tokenHandler.WriteToken(token);
            user.Password = null;
            return user;
        }
    }
}
