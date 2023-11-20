using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using InOutVehicleManager.Core;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;
using Microsoft.IdentityModel.Tokens;

namespace InOutVehicleManager.Api.Extensions;

public class JwtExtension
{
    public static string Generate(ResponseData data)
    {
        var handler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Configuration.Secrets.JwtPrivateKey);
        var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = GenerateClaims(data),
            Expires = DateTime.UtcNow.AddHours(12),
            SigningCredentials = credentials
        };
        var token = handler.CreateToken(tokenDescriptor);
        return handler.WriteToken(token);
    }

    public static ClaimsIdentity GenerateClaims(ResponseData user)
    {
        var claimsIdentity = new ClaimsIdentity();
        claimsIdentity.AddClaim(new Claim("Id", user.Id));
        claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, user.Email));

        foreach (var role in user.Roles)
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, role));

        return claimsIdentity;
    }
}
