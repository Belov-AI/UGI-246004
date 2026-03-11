using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RegisteredUser : User
    {
        public string Email;
        protected int passwordHash;

        public RegisteredUser(string login, string email, string password) : base(login)
        {
            Email = email;

            if (password.Length < 8)
                throw new ArgumentException("Парооль должен быть не менее 8 символов");

            this.passwordHash = password.GetHashCode();
        }

        public override string GetInfo() => 
            $"Зарегистрированный пользователь {Login}, e-mail {Email}";
    }
}
