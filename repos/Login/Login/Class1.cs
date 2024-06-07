using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
   class LoginDetails
    {
        private String userName;
        private String password;

        public LoginDetails(string userName, String password)
        {
            this.userName = userName;
            this.password = password;
        }
        public void setLoginDetails(string userName, String password)
        {
            this.password = password;
            this.userName = userName;
        }
        public void setUserName(String userName)
        {
            this.userName=userName;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public String getUserName()
        {
            return this.userName;
        }
        public string getPassword()
        {
            return password;
        }
        public string recovery()
        {
            return ("user name: "+userName+"\npassword: "+password+"\n");
        }
    }
}
