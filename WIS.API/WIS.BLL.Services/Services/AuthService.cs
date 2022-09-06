using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WIS.BLL.Services.Interfaces.Interfaces;
using WIS.BLL.Services.Models.Models;
using WIS.Data.DataAccess.Interfaces.UoW;
using WIS.Data.DataAccess.Models.Entities;

namespace WIS.BLL.Services.Services
{
    public class AuthService : IAuthService
    {
        private IUnitOfWork _unitOfWork;

        public AuthService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<object> SignInAsync(UserDTO userDTO)
        {
            return await GetToken(userDTO);
        }

        public async Task<object> SignUpAsync(UserDTO userDTO)
        {
            User user = new User
            {
                UserName = userDTO.FirstName + '.' + userDTO.LastName,
                Email = userDTO.Email,
            };
            await _unitOfWork.IdentityUserManager.CreateAsync(user, userDTO.Password);
            await _unitOfWork.SaveChangesAsync();
            return await GetToken(userDTO);
        }

        public async Task<object> GetToken(UserDTO userDTO)
        {
            User user = await _unitOfWork.IdentityUserManager.FindByEmailAsync(userDTO.Email);

            if (user is not null && await _unitOfWork.IdentityUserManager.CheckPasswordAsync(user, userDTO.Password))
            {
                IdentityOptions options = new IdentityOptions();
                SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserId", user.Id.ToString()),
                        new Claim("UserName", user.UserName.ToString()),
                    }),
                    Expires = DateTime.Now.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
                };
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                SecurityToken securityToken = tokenHandler.CreateToken(tokenDescriptor);
                string token = tokenHandler.WriteToken(securityToken);

                return new { token };
            }
            else
            {
                throw new Exception();
            }

        }
    }
}
