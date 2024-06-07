namespace Logins
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            username = new TextBox();
            password = new TextBox();
            confirmPassword = new TextBox();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(356, 279);
            button1.Name = "button1";
            button1.Size = new Size(247, 36);
            button1.TabIndex = 0;
            button1.Text = "Sign_Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(283, 32);
            label1.Name = "label1";
            label1.Size = new Size(180, 27);
            label1.TabIndex = 1;
            label1.Text = "Register Now";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(161, 146);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(161, 192);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 3;
            label3.Text = "password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(161, 236);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 4;
            label4.Text = "confirm password";
            label4.Click += label4_Click;
            // 
            // username
            // 
            username.Location = new Point(356, 144);
            username.Name = "username";
            username.Size = new Size(247, 23);
            username.TabIndex = 5;
            // 
            // password
            // 
            password.Location = new Point(356, 190);
            password.Name = "password";
            password.Size = new Size(247, 23);
            password.TabIndex = 6;
            // 
            // confirmPassword
            // 
            confirmPassword.Location = new Point(356, 234);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(247, 23);
            confirmPassword.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Cyan;
            linkLabel1.Location = new Point(356, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 21);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign_In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(161, 337);
            label5.Name = "label5";
            label5.Size = new Size(193, 21);
            label5.TabIndex = 9;
            label5.Text = "Already have an account?";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 406);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(confirmPassword);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private LinkLabel linkLabel1;
        private Label label5;
        private TextBox username;
        private TextBox password;
        private TextBox confirmPassword;
    }
}