using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VipUser : RegisteredUser
    {
        private long cardNumber;

        public VipUser(long cardNumber, string login, string email, string password) :
            base(login, email, password)
        {
            this.cardNumber = cardNumber;
        }
    }
}
