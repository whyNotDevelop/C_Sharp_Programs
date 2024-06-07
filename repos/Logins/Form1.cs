namespace Logins
{
    using System;
    using System.Collections;
    using System.IO;

    public partial class Form1 : Form
    {
        private ArrayList usersList = new ArrayList();
        private MyDatabase database = new MyDatabase();
        public Form1()
        {


            InitializeComponent();
            string[] lines = database.readTextFile();
            string username,password;
            string[] content;

            foreach(string line in lines)
            {
                content = line.Split(',');
                username = content[0];
                password = content[1];  
                usersList.Add(new MyDatabase(username,password));

            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = userNameInput.Text;
            string pass = passwordInput.Text;

            if (database.checkUser(userInput,pass, usersList))
            {
                div.Text = "Welcome ";
            }
            else
            {
                div.Text = "Invalid Input";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userInput, pass;
            userInput = userNameInput.Text;
            pass = passwordInput.Text;

            database.setUsername(userInput);
            database.setPassword(pass);

            if (database.checkUser(userInput,pass,usersList))
            {
                div.Text = "You already exist";
            }
            else
            {
                usersList.Add(new Users(userInput, pass));
                updateUser();


            }

        }

        private void updateUser()
        {
            string filePath = "C:\\Users\\Student\\Desktop\\users.txt";

            using (StreamWriter write = new StreamWriter(filePath))
                foreach (Users user in usersList)
                {
                    write.WriteLine(user.getUsername() + "," + user.getPassword());

                }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    internal class Users
    {
        private string username;
        private string password;

        public Users(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
    }
}