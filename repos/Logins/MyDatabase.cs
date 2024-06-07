using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.IO;
using System.Collections;

namespace Logins
{
    internal class MyDatabase
    {
        private ArrayList usersList = new ArrayList();
        private string username;
        private string password;

        public MyDatabase()
        {
            username = null;
            password = null;
        }
        public MyDatabase(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void setUsername(string username)
        {
            this.username=username;
        }
        public void setPassword(string password)
        {
            this.password=password;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
        public bool checkUser(string name, string password, ArrayList usersList)
        {
            bool found = false;
      
            if (username != null & password!= null)
            {
                string str1, str2;
                foreach (MyDatabase user in usersList)
                {
                    str1 = user.getUsername();
                    str2 = user.getPassword();


                    if (string.Equals(str1, name, StringComparison.Ordinal) & string.Equals(str2, password, StringComparison.Ordinal))
                    {
                        found = true;
                        break;

                    }

                }
            }
            return found;

        }
        public string[] readTextFile()
        {
            Users user;
            string userdata,password;
            string filePath = "C:\\Users\\Student\\Desktop\\users.txt";
            string[] lines = File.ReadAllLines(filePath);
            string[] content;
            
            return lines;
            
        }
        public void updatePassword()
        {

        }
        
        public void addUser()
        {

        }

        public void removeUser()
        {

        }
        public void searchUser()
        {

        }
    }
}

