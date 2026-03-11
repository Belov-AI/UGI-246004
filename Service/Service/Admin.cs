using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Admin : RegisteredUser
    {
        protected int accessLevel;
        
        public Admin(string login, string email, string password, int level) :
            base(login, email, password) 
        { 
            accessLevel = level;
        }

        public bool CheckPassword(string password) => password.GetHashCode() == passwordHash;

        public int GetLevel() => accessLevel;

        protected void ChangeLevel(Admin admin, int level)
        {
            if(admin is SuperAdmin)
                this.accessLevel = level;
        }

        public void ChanhePassword(string newPassword, string oldPasswod)
        {
            if(oldPasswod.GetHashCode() == passwordHash)
                passwordHash = newPassword.GetHashCode();
        }

        public override sealed string GetInfo() =>
            $"Администратор {Login}, уровень доступа {accessLevel}";
    }

}
