using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UserAuthProject.Data;

namespace UserAuthProject.Services
{
    public static class UserService
    {
        public static void RegisterUser(string email, string password)
        {
            using var context = new UserContext();
            if (context.Users.Any(u => u.Email == email))
            {
                throw new Exception("Email already exists");
            }

            var user = new User
            {
                Email = email,
                PasswordHash = HashPassword(password)
            };

            context.Users.Add(user);
            context.SaveChanges();
        }

        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
    }
}
