namespace Logins
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Sign_In = new Button();
            label1 = new Label();
            label2 = new Label();
            userNameInput = new TextBox();
            passwordInput = new TextBox();
            div = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Sign_In
            // 
            Sign_In.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Sign_In.Location = new Point(324, 310);
            Sign_In.Name = "Sign_In";
            Sign_In.Size = new Size(212, 33);
            Sign_In.TabIndex = 0;
            Sign_In.Text = "Sign_In";
            Sign_In.UseVisualStyleBackColor = true;
            Sign_In.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(193, 222);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 2;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(193, 264);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 3;
            label2.Text = "password";
            label2.Click += label2_Click;
            // 
            // userNameInput
            // 
            userNameInput.Location = new Point(324, 220);
            userNameInput.Name = "userNameInput";
            userNameInput.Size = new Size(212, 23);
            userNameInput.TabIndex = 4;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(324, 266);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(212, 23);
            passwordInput.TabIndex = 5;
            // 
            // div
            // 
            div.AutoSize = true;
            div.Location = new Point(243, 293);
            div.Name = "div";
            div.Size = new Size(0, 15);
            div.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(232, 21);
            label3.Name = "label3";
            label3.Size = new Size(278, 27);
            label3.TabIndex = 7;
            label3.Text = "WELCOME TO YOUR APP";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(193, 367);
            label4.Name = "label4";
            label4.Size = new Size(179, 20);
            label4.TabIndex = 9;
            label4.Text = "Do not have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Cyan;
            linkLabel1.Location = new Point(378, 367);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 21);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign_Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(731, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(div);
            Controls.Add(passwordInput);
            Controls.Add(userNameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Sign_In);
            Name = "Form1";
            Text = "`";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Sign_In;
        private Label label1;
        private Label label2;
        private TextBox userNameInput;
        private TextBox passwordInput;
        private Label div;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}