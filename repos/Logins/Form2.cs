﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logins
{
    public partial class Form2 : Form
    {
        private Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            form1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput, confirmPass, passwordInput;
            userInput = username.Text;
            confirmPass = confirmPassword.Text;
            passwordInput = password.Text;

            if (string.Equals(confirmPass, passwordInput,StringComparison.Ordinal))
            {
                if (form1.checkUser())
                {
                    MessageBox.Show("You alrady have an account try logging in");
                }
                else
                {

                    usersList.Add(new Users(userInput, passwordInput));
                    updateUser();


                }
            }
        }
    }
}
