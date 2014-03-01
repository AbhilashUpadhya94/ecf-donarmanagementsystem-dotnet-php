using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public partial class Login
    {
        public Boolean IsValidUser(String pwd)
        {
            if(this.Password == pwd)
            {
                return true;
            }
            return false;
        }
    }
}
