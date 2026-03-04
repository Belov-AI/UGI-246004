using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class SuperAdmin : Admin
    {
        string phoneNumer;

        public SuperAdmin(string login, string email, string password, string phone) : 
            base(login, email, password, -1)
        {
            phoneNumer = phone;
        }
    }
}
