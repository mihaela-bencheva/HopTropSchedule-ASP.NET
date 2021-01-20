using Data.DataConnection;
using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Services.DTOModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace Services
{
    public class IdentityService
    {
        private readonly ScheduleDbContext _dbContext;

        public IdentityService(ScheduleDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public string RegisterUser(RegisterDto user)
        {
            var danceGroupID = _dbContext.DanceGroups.Where(
                        y => y.DanceGroupName == user.DanceGroupName
                        ).FirstOrDefault().ID;
            var ifExist = _dbContext.Users.FirstOrDefault(h => h.Email == user.Email);

            if (ifExist == null)
            {
                bool passwordValidation = CheckUserPassword(user);
                if (user.CheckPassword == user.Password && passwordValidation == true)
                {
                    string hashedPassword = Hash(user.Password);

                    _dbContext.Users.Add(new User()
                    {
                        Email = user.Email,
                        Password = hashedPassword,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        PhoneNumber = user.PhoneNumber,
                        DanceGroupId = danceGroupID
                    });
                    _dbContext.SaveChanges();
                }
                return TokenSetup(user.Email);
            }
            return string.Empty;
        }

        public string LogInUser(UserDto user)
        {
            using (_dbContext)
            {
                var userLogin = _dbContext.Users.FirstOrDefault(x => x.Email == user.Email);
                if (userLogin != null)
                {
                    if (userLogin.Password == Hash(user.Password))
                    {
                        var token = TokenSetup(user.Email);
                        return token;
                    }
                }
                return string.Empty;
            }
        }

        public bool UserChangePassword(RegisterDto user)
        {
            var ifExists = _dbContext.Users.Where(x => x.Email == user.Email).FirstOrDefault();
            if (ifExists != null)
            {
                bool passwordValidation = CheckUserPassword(user);
                if (user.CheckPassword == user.Password && passwordValidation == true)
                {
                    string hashedPassword = Hash(user.Password);

                    _dbContext.Users.Add(new User()
                    {
                        Email = user.Email,
                        Password = hashedPassword,
                    });
                    _dbContext.SaveChanges();
                } 
                return true;
            }
            return false;
        }

        private string TokenSetup(string email)
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var file = Path.Combine(path, "tokenconfig.json");
            string salt;
            string issuer;
            string audience;
            double accessExpiration;

            using (StreamReader sr = new StreamReader(file))
            {
                string content = sr.ReadToEnd();
                var jsonObject = (JObject)JsonConvert.DeserializeObject(content);
                salt = jsonObject["secret"].Value<string>();
                issuer = jsonObject["Issuer"].Value<string>();
                audience = jsonObject["audience"].Value<string>();
                accessExpiration = jsonObject["AccessExpiration"].Value<double>();
            }
            var claim = new List<Claim>()
                {
                  new Claim(ClaimTypes.Email, email),

                };
            string token = string.Empty;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(salt));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                issuer,
                audience,
                claim,
                expires: DateTime.Now.AddMinutes(accessExpiration),
                signingCredentials: credentials
            );
            token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return token;
        }

        private string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        private bool CheckUserPassword(RegisterDto model)
        {
            bool result =
                    model.Password.Any(c => char.IsLetter(c)) &&
                    model.Password.Any(c => char.IsDigit(c)) &&
                    model.Password.Any(c => char.IsSymbol(c));
            if (result == true)
            {
                if (model.Password == model.CheckPassword)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}


