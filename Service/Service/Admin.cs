using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Admin : RegisteredUser
    {
        readonly public int AccessLevel;
        
        public Admin(string login, string email, string password, int level) :
            base(login, email, password) 
        { 
            AccessLevel = level;
        }

        public bool CheckPassword(string password) => password.GetHashCode() == passwordHash; 
    }
}
