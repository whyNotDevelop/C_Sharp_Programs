namespace myForm
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
            label1 = new Label();
            password = new Label();
            btnLogin = new Button();
            btnSignUp = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 164);
            label1.Name = "label1";
            label1.Size = new Size(148, 17);
            label1.TabIndex = 0;
            label1.Text = "Enter Account Number";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(81, 260);
            password.Name = "password";
            password.Size = new Size(94, 17);
            password.TabIndex = 1;
            password.Text = "Enter Amount";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.Location = new Point(81, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Exit";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.Control;
            btnSignUp.Location = new Point(284, 295);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 29);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Proceed";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(159, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Savings Account", "Check Account" });
            comboBox1.Location = new Point(81, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Select Type of Bank Account";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.LightSteelBlue;
            radioButton1.Location = new Point(81, 205);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Withdraw";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.LightSteelBlue;
            radioButton2.Location = new Point(81, 230);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Deposit";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(529, 418);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(password);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label password;
        private Button btnLogin;
        private Button btnSignUp;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}