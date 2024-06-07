
using System.IO;
namespace Login
{
    class Program
    {
        private static void Main(string[] args)
        {
            LoginDetails[] login = new LoginDetails[5];
            //b) Load the content of the file into the array of object created above.
            String path = "C:\\Users\\Student\\Documents\\userNames.txt";
            String path2 = "C:\\Users\\Student\\Documents\\userPasswords.txt";

            if(File.Exists(path) && File.Exists(path2))
            {
                Console.WriteLine("Files indeed exist");
                String[] userNames = File.ReadAllLines(path);
                String[] passwords = File.ReadAllLines(path2);

                //foreach(String user in userNames){ }
                for (int i=0; i<login.Length; i++)
                {
                    login[i] = new LoginDetails(userNames[i], passwords[i]);
                }
                Console.Write("Enter Username: ");
                String username = Console.ReadLine();
                Console.Write("Enter password: ");
                String password = Console.ReadLine();
                bool loggedIn = false;

                for (int k = 0; k < login.Length; k++)
                {
                    String str = login[k].getPassword();
                    String str2 = login[k].getUserName();
                    //str.Equals(password,StringComparison.Ordinal) && str2.Equals(username,StringComparison.Ordinal)
                    if (string.Equals(str, password, StringComparison.Ordinal) && string.Equals(str2, username, StringComparison.Ordinal))
                    {
                        loggedIn = true;
                        break;
                    }
                }
                if (loggedIn)
                {
                    Console.WriteLine("You have successfully logged in!");
                }
                else
                {
                    Console.WriteLine("Check password or username, invalid login!");
                }
            }
            else
            {
                Console.WriteLine("File doee not exist");
            }
            
        }
    }
}