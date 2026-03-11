using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class WebService
    {
        static List<User> users;

        static WebService()
        {
            users = new List<User>();
        }

        public static void LogIn(User user)
        {
            if (!users.Contains(user)) 
            {
                users.Add(user);
                Logger.LogInfo($"{user.Login} присоединился к сервису");
            }  
        }

        public static void LogOut(User user) 
        {
            if (users.Contains(user)) 
            {
                users.Remove(user);
                Logger.LogInfo($"{user.Login} отсоединился от сервиса");
            }           
        }

        public static string[] GetUserNames()
        {
            var userNames = new string[users.Count];

            for (int i = 0; i < users.Count; i++)
                userNames[i] = users[i].Login;

            return userNames;
        }

        public static List<string> GetUsersInfo()
        {
            var result = new List<string>();

            foreach (var user in users)
                result.Add(user.GetInfo());

            return result;
        }
    }
}
