namespace library
{
    partial class Addbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addbook));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ISBNnumbertxt = new TextBox();
            label5 = new Label();
            CancelBtn = new Button();
            Savebtn = new Button();
            textAuthorName = new TextBox();
            textBookName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 94);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 10);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(ISBNnumbertxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CancelBtn);
            panel2.Controls.Add(Savebtn);
            panel2.Controls.Add(textAuthorName);
            panel2.Controls.Add(textBookName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 97);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 391);
            panel2.TabIndex = 1;
            // 
            // ISBNnumbertxt
            // 
            ISBNnumbertxt.Font = new Font("Microsoft YaHei", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNnumbertxt.Location = new Point(349, 257);
            ISBNnumbertxt.Margin = new Padding(2, 1, 2, 1);
            ISBNnumbertxt.Name = "ISBNnumbertxt";
            ISBNnumbertxt.Size = new Size(270, 32);
            ISBNnumbertxt.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(66, 256);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(180, 35);
            label5.TabIndex = 10;
            label5.Text = "ISBN Number";
            label5.Click += label5_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.FlatStyle = FlatStyle.Popup;
            CancelBtn.Location = new Point(592, 356);
            CancelBtn.Margin = new Padding(2, 1, 2, 1);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(81, 22);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // Savebtn
            // 
            Savebtn.FlatStyle = FlatStyle.Popup;
            Savebtn.Location = new Point(460, 356);
            Savebtn.Margin = new Padding(2, 1, 2, 1);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(81, 22);
            Savebtn.TabIndex = 8;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += Savebtn_Click;
            // 
            // textAuthorName
            // 
            textAuthorName.Font = new Font("Microsoft YaHei", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            textAuthorName.Location = new Point(349, 162);
            textAuthorName.Margin = new Padding(2, 1, 2, 1);
            textAuthorName.Name = "textAuthorName";
            textAuthorName.Size = new Size(270, 32);
            textAuthorName.TabIndex = 5;
            textAuthorName.TextChanged += textBox3_TextChanged;
            // 
            // textBookName
            // 
            textBookName.Font = new Font("Microsoft YaHei", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBookName.Location = new Point(349, 67);
            textBookName.Margin = new Padding(2, 1, 2, 1);
            textBookName.Name = "textBookName";
            textBookName.Size = new Size(270, 32);
            textBookName.TabIndex = 4;
            textBookName.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 161);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 35);
            label2.TabIndex = 1;
            label2.Text = "Author Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 35);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(294, 24);
            label3.Name = "label3";
            label3.Size = new Size(249, 40);
            label3.TabIndex = 2;
            label3.Text = "Add New Book";
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(750, 489);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Addbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addbook";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button CancelBtn;
        private Button Savebtn;
        private TextBox textAuthorName;
        private TextBox textBookName;
        private TextBox ISBNnumbertxt;
        private Label label5;
        private Label label3;
    }
}