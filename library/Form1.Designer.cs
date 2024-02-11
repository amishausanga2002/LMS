namespace library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>B
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            usernametext = new TextBox();
            passwordText = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            loginbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(260, 16);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 124);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 31);
            label1.TabIndex = 1;
            label1.Text = "Library Management System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(244, 165);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 2;
            label2.Text = "User Login";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(144, 243);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // usernametext
            // 
            usernametext.BackColor = SystemColors.ActiveCaption;
            usernametext.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            usernametext.Location = new Point(272, 270);
            usernametext.Margin = new Padding(2, 1, 2, 1);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(199, 36);
            usernametext.TabIndex = 4;
            usernametext.Text = "Username";
            usernametext.MouseClick += usernametext_MouseClick;
            usernametext.TextChanged += usernametext_TextChanged;
            usernametext.MouseEnter += usernametext_MouseEnter;
            // 
            // passwordText
            // 
            passwordText.BackColor = SystemColors.ActiveCaption;
            passwordText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordText.Location = new Point(272, 399);
            passwordText.Margin = new Padding(2, 1, 2, 1);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(199, 34);
            passwordText.TabIndex = 5;
            passwordText.Text = "Password";
            passwordText.MouseClick += passwordText_MouseClick;
            passwordText.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(39, 417);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(144, 370);
            pictureBox4.Margin = new Padding(2, 1, 2, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 73);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loginbtn.Location = new Point(262, 516);
            loginbtn.Margin = new Padding(2, 1, 2, 1);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(96, 34);
            loginbtn.TabIndex = 11;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(625, 595);
            Controls.Add(loginbtn);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(passwordText);
            Controls.Add(usernametext);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox usernametext;
        private TextBox passwordText;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button loginbtn;
    }
}
