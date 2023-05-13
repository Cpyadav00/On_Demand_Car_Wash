using Microsoft.IdentityModel.Tokens;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace On_Demand_Car_Wash.Repository
{
    public class TokenRepository : IToken
    {
        CarDbContext _context;
        private readonly IConfiguration _configuration;

        public TokenRepository(CarDbContext context, IConfiguration config)
        {
            _context = context;
            _configuration = config;
        }

        public string CreateToken(Login login)
        {
            try
            {
                List<Claim> claims = new List<Claim>
                {
                 new Claim(ClaimTypes.Email, login.Email),
                new Claim(ClaimTypes.Role, login.Role)
                 };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                    _configuration.GetSection("AppSettings:Token").Value));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

                var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds);

                var jwt = new JwtSecurityTokenHandler().WriteToken(token);

                return jwt;


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
    }
}
