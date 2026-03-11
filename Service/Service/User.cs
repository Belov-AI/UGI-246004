using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class User
    {
        readonly string login;

        public string Login => login;

        public User(string userLogin)
        {
            foreach (var ch in userLogin)
                if (!char.IsLetterOrDigit(ch))
                    throw new ArgumentException(
                        $"{userLogin}: логин должен содержать только буквы и цифры");
                else
                    login = userLogin;

            Logger.LogInfo($"Пользователь {login} создан");
        }

        ~User()
        {
            Logger.LogInfo($"Пользователь {login} удалён из памяти");
        }

        public virtual string GetInfo() => $"Пользователь {Login}";
    }
}
